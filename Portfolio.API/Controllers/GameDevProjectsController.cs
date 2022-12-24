using Microsoft.AspNetCore.Mvc;
using Core.HttpDynamo;
using Core.JwtBuilder;
using System.Security.Claims;
using Microsoft.Extensions.Caching.Memory;
using Portfolio.API.Models;

namespace Portfolio.API.Controllers
{
    [ApiController]
    [Route("Projects/GameDev")]
    public class GameDevProjectsController : ControllerBase
    {

        private readonly ILogger<GameDevProjectsController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _config;
        private readonly IMemoryCache _memoryCache;

        private const string LudumCacheDareKey = "LudumDareGames";
        private const string SteamCacheKey = "SteamGames";

        public GameDevProjectsController(ILogger<GameDevProjectsController> logger, IHttpClientFactory httpClientFactory, IConfiguration configuration, IMemoryCache memoryCache)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
            _config = configuration;
            _memoryCache = memoryCache;
        }

        [HttpGet]
        [Route("LudumDare")]
        public async Task<IActionResult> GetLudumDareProjects([FromQuery(Name ="refresh")] bool? refresh = false)
        {
            LudumDareData cachedResponse;
            if (_memoryCache.TryGetValue(LudumCacheDareKey, out cachedResponse) && !refresh.GetValueOrDefault())
            {
                return Ok(cachedResponse);
            }
            else
            {
                var token = JwtTokenGenerator.GenerateToken(_config, new[] { new Claim("source", "portfolio") });
                var response = await HttpDynamo.GetRequestAsync< LudumDareData>(_httpClientFactory, "https://projectsludumdare20221120164815.azurewebsites.net/Projects/LudumDare/Games/dandala88", token, null);
                _memoryCache.Set(LudumCacheDareKey, response, DateTime.UtcNow + TimeSpan.FromHours(24));
                return Ok(response);
            }
        }

        [HttpGet]
        [Route("Steam")]
        public async Task<IActionResult> GetSteamProjects([FromQuery(Name = "refresh")] bool? refresh = false)
        {
            List<SteamData> cachedResponse;
            if (_memoryCache.TryGetValue(SteamCacheKey, out cachedResponse) && !refresh.GetValueOrDefault())
            {
                return Ok(cachedResponse);
            }
            else
            {
                var token = JwtTokenGenerator.GenerateToken(_config, new[] { new Claim("source", "portfolio") });
                var response = await HttpDynamo.GetRequestAsync<List<SteamData>>(_httpClientFactory, "https://projectssteam20221120215756.azurewebsites.net/Steam/Game?appId=1648160&appId=1940550", token, null);
                _memoryCache.Set(SteamCacheKey, response, DateTime.UtcNow + TimeSpan.FromHours(24));

                return Ok(response);
            }
        }
    }
}
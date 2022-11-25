using Microsoft.AspNetCore.Mvc;
using Core.HttpDynamo;
using Core.JwtBuilder;
using System.Security.Claims;

namespace Portfolio.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectsController : ControllerBase
    {

        private readonly ILogger<ProjectsController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _config;

        public ProjectsController(ILogger<ProjectsController> logger, IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
            _config = configuration;
        }

        [HttpGet]
        [Route("LudumDare")]
        public async Task<IActionResult> Get()
        {
            var token = JwtTokenGenerator.GenerateToken(_config, new[] { new Claim("source", "portfolio") });
            var response = await HttpDynamo.GetRequestAsync(_httpClientFactory, "https://projectsludumdare20221120164815.azurewebsites.net/Projects/LudumDare/Games/dandala88", token);
            return Ok(response);
        }
    }
}
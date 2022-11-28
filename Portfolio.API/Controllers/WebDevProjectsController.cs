﻿using Core.HttpDynamo;
using Core.JwtBuilder;
using Microsoft.AspNetCore.Mvc;
using Portfolio.API.Models;
using System.Security.Claims;

namespace Portfolio.API.Controllers
{
    [ApiController]
    [Route("Projects/WebDev")]
    public class WebDevProjectsController : Controller
    {
        private readonly ILogger<GameDevProjectsController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _config;

        public WebDevProjectsController(ILogger<GameDevProjectsController> logger, IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
            _config = configuration;
        }

        [HttpGet]
        [Route("DotNet")]
        public async Task<IActionResult> GetDotNetProjects()
        {
            var token = JwtTokenGenerator.GenerateToken(_config, new[] { new Claim("source", "portfolio") });
            var resourceGroupList = await HttpDynamo.GetRequestAsync<List<ResourceGroup>>(_httpClientFactory, "https://projectsazure20221128090301.azurewebsites.net/Azure/Resource/Groups", token);

            var resources = new List<Resource>();

            foreach(var resourceGroup in resourceGroupList)
            {
                var resourceList = await HttpDynamo.GetRequestAsync<List<Resource>>(_httpClientFactory, $"https://projectsazure20221128090301.azurewebsites.net/Azure/Resources/Sites/{resourceGroup.Name}", token);

                if(resourceList != null)
                    resources.AddRange(resourceList);
            }

            var gitHubRepoList = new List<GitHubRepo>();
            foreach(var resource in resources)
            {
                var repos = await HttpDynamo.GetRequestAsync<GitHubRepo>(_httpClientFactory, $"https://projectsgithub20221128090558.azurewebsites.net/repo{resource.RepoPath}", token);

                if(repos != null)
                    gitHubRepoList.Add(repos);
            }

            return Ok(gitHubRepoList);
        }
    }
}
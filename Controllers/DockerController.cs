using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Docker.DotNet;

namespace docker_mobile_api.Controllers
{
    [Route("api/[controller]")]
    public class DockerController : Controller
    {
        private readonly IDockerClient _dockerClient;

        public DockerController(IDockerClient dockerClient){
            this._dockerClient = dockerClient;    
        }

        [HttpGet]
        public async Task<IActionResult> GetDockerInfo()
        {
            var info = await this._dockerClient.System.GetVersionAsync();
            return new JsonResult(info);
        }
    }
}

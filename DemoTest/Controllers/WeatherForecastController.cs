using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoTest.Core;
using DemoTest.RequestModels;
using DemoTest.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoTest.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        /*
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        */

        private readonly IUserService _userService;

        public WeatherForecastController(IUserService userService)
        {
            _userService = userService;
        }

        /*
        [HttpGet]
        public async Task<List<User>> Get()
        {
            string uid = "349454545";
            _userService.saveUser(uid);
            return await Task.Run(() => _userService.getAllUsers());

        }
        */

        [HttpGet]
        public User Get()
        {
            //var user = _userService.saveUser("Alex");
            Guid guid = new Guid("3297F0F2-35D3-4231-919D-1CFCF4035975");
            User result = _userService.getUserByUid(guid);
            return result;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Test([FromBody] UserRequest data)
        {
            var user = _userService.saveUser(data.Name, data.Score);
            return Ok(user);
        }

    }

}

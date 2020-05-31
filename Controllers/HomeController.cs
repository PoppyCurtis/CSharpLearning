using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using csharp_learning.Models;
using Newtonsoft.Json;


namespace csharp_learning.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        private readonly ILogger<HomeController> _logger;

        public IActionResult Index()
        {
            return View();
        }



        public string Privacy()
        {
            var user = new User
            {
                Username = "todd",
                Fullname = "Todd Spatafore",
                Password = "secret password"
            };
            var json = JsonConvert.SerializeObject(user, Formatting.Indented);
            _logger.LogInformation(json);
            return json;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

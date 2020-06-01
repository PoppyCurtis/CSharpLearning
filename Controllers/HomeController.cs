using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using csharp_learning.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Routing;

namespace csharp_learning.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        private readonly LinkGenerator _linkGenerator;

        public HomeController(
            ILogger<HomeController> logger,
            LinkGenerator linkGenerator
        )
        {
            _logger = logger;
            _linkGenerator = linkGenerator;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Link() 
        {
            var link = _linkGenerator.GetPathByAction("Privacy", "Home");
            return Content(link);
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

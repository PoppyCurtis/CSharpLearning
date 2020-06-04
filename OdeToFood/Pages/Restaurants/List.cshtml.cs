using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace OdeToFood.Pages.Restaurants
{
    public class IndexModel : PageModel
    {

        private readonly IConfiguration config;
        public string Message { get; set; }

        public IndexModel(IConfiguration config) 
        {
            this.config = config;
        }

        public void OnGet()
        {
            Message = config["Message"];
            //Output regular message = 
            //Message = "Hello World";
        }
    }
}

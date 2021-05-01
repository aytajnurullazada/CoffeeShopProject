using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult AboutMe()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

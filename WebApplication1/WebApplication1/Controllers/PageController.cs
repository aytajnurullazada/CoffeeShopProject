using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class PageController : Controller
    {
        public IActionResult RecipeMenu()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult Faq()
        {
            return View();
        }
        public IActionResult ReserveTable()
        {
            return View();
        }
        public IActionResult ReserveForm()
        {
            return View();
        }
    }
}

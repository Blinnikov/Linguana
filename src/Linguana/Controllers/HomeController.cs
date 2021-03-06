﻿using Microsoft.AspNet.Mvc;

namespace Linguana.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            var appName = "Linguana";
            var message = $"'{appName}' description page.";

            return View("About", message);
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}

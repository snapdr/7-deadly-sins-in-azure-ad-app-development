﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AppWithRoles.Models;
using Microsoft.AspNetCore.Authorization;
using AppWithRoles.Authorization;

namespace AppWithRoles.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Policies.AdminOnly)]
        public IActionResult Admin()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

/*
    Copyright © 2026 Angle-Tolib, All Rights Reserved.
 */

using Microsoft.AspNetCore.Mvc;

namespace Monolit.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

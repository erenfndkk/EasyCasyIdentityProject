﻿using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
    public class MyProfiileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

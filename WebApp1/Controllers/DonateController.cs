﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
    public class DonateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

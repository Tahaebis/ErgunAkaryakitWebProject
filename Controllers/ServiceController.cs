﻿using Microsoft.AspNetCore.Mvc;

namespace ErgunAkaryakitWebProject.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Services()
        {
            return View();
        }
    }
}

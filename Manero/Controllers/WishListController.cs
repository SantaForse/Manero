﻿using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers
{
    public class WishListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

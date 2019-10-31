﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pita_Pit_Inventory.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Product/Add")]
        public IActionResult AddProductPage()
        {
            return View("AddProduct");
        }

        [HttpGet("Product/View")]
        public IActionResult ViewProductPage()
        {
            return View("ViewProducts");
        }
    }
}
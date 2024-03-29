﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SpinutechCodeTest.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SpinutechCodeTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Convert(Palindrome palindrome)
        {
            string numStr = palindrome.input.ToString();
            string newStr = "";

            for (int i = numStr.Length - 1; i >= 0; i--)
            {
                newStr += numStr[i];
            }

            if (newStr == numStr)
                palindrome.isPalindrome = true;

            return View("Index", palindrome);
        }
    }
}

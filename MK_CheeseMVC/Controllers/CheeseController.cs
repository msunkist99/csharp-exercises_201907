﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MK_CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        //public static List<string> Cheeses = new List<string>();
        public static Dictionary<string, string> Cheeses = new Dictionary<string,string>();

        public IActionResult Index()
        {
            ViewBag.cheeses = Cheeses;
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("Cheese/Add")]
        public IActionResult NewCheese(string name, string description)
        {
            //Cheeses.Add(name);
            Cheeses.Add(name, description);
            return Redirect("/Cheese");
        }
    }
}
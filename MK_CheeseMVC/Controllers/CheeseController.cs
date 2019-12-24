using System;
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
        public static string Error = null;

        public IActionResult Index()
        {
            ViewBag.cheeses = Cheeses;
            //ViewBag.error = null;
            return View();
        }

        public IActionResult Add()
        {
            ViewBag.error = Error;
            return View();
        }

        [HttpPost]
        [Route("Cheese/Add")]
        public IActionResult NewCheese(string name, string description)
        {
            if (string.IsNullOrEmpty(name))
            {
                Error = "Please enter cheesename";
                return Redirect("/Cheese/Add");
            }
            else
            {
                Error = null;
            }

            //Cheeses.Add(name);
            Cheeses.Add(name, description);
            return Redirect("/Cheese");
        }

        public IActionResult DeleteCheckbox()
        {
            ViewBag.cheeses = Cheeses;
            return View();
        }

        public IActionResult DeleteDropdownList()
        {
            ViewBag.cheeses = Cheeses;
            return View();
        }

        [HttpPost]
        [Route("Cheese/DeleteDropdownList")]
        [Route("Cheese/DeleteCheckbox")]
        public IActionResult Delete(string[] names) {

            foreach (string name in names)
            {
                Cheeses.Remove(name);
            }

            return Redirect("/Cheese");
        }

    }
}
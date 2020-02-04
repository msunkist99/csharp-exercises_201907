using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MK_CheeseMVC.Models;

namespace MK_CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        //static List<string> Cheeses = new List<string>();
        //static Dictionary<string, string> Cheeses = new Dictionary<string,string>();
        //static Dictionary<string, Cheese> Cheeses = new Dictionary<string, Cheese>();


        public static string Error = null;

        public IActionResult Index()
        {
            ViewBag.cheeses = CheeseData.GetAll();
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
        //public IActionResult NewCheese(string name, string description)
        public IActionResult NewCheese(Cheese cheese)
        {
            if (string.IsNullOrEmpty(cheese.Name))
            {
                Error = "Please enter cheese name";
                return Redirect("/Cheese/Add");
            }

            foreach (char character in cheese.Name)
            {
                if (Char.IsNumber(character))
                {
                    Error = "Please enter valid cheese name without numbers";
                    return Redirect("/Cheese/Add");
                }
            }

            Error = null;

            /*Cheese cheese = new Cheese
            {
                Name = name,
                Description = description
            };
            */
                
            CheeseData.Add(cheese);

            return Redirect("/Cheese");
        }

        public IActionResult DeleteCheckbox()
        {
            ViewBag.title = "Remove Cheeses with Checkboxes";
            ViewBag.cheeses = CheeseData.GetAll();
            return View();
        }

        public IActionResult DeleteDropdownList()
        {
            ViewBag.title = "Remove Cheeses with Dropdown List";
            ViewBag.cheeses = CheeseData.GetAll();
            return View();
        }

        [HttpPost]
        [Route("Cheese/DeleteDropdownList")]
        [Route("Cheese/DeleteCheckbox")]
        public IActionResult Delete(int[] cheeseIds) {

            foreach (int cheeseId in cheeseIds)
            {
                CheeseData.Remove(cheeseId);
            }

            return Redirect("/Cheese");
        }

    }
}
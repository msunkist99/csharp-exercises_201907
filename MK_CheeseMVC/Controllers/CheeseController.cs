using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MK_CheeseMVC.Models;
using MK_CheeseMVC.ViewModels;

namespace MK_CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        //static List<string> Cheeses = new List<string>();
        //static Dictionary<string, string> Cheeses = new Dictionary<string,string>();
        //static Dictionary<string, Cheese> Cheeses = new Dictionary<string, Cheese>();


        //public static string Error = null;

        [HttpGet]
        public IActionResult Index()
        {
            List<Cheese> cheeses = CheeseData.GetAll();
            //ViewBag.cheeses = CheeseData.GetAll();
            //ViewBag.error = null;
            return View(cheeses);
        }

        [HttpGet]
        public IActionResult Add()
        {
            //ViewBag.title = "Add Cheese";
            //ViewBag.error = Error;

            AddCheeseViewModel addCheeseViewModel = new AddCheeseViewModel();

            return View(addCheeseViewModel);
        }

        [HttpPost]
        //public IActionResult Add(string name, string description)
        //public IActionResult NewCheese(Cheese cheese)
        public IActionResult Add(AddCheeseViewModel addCheeseViewModel)
        {
            /*
             * if (string.IsNullOrEmpty(cheese.Name))
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

            if (ModelState.IsValid)
            {
                Cheese cheese = new Cheese()
                {
                    Name = addCheeseViewModel.Name,
                    Description = addCheeseViewModel.Description,
                    Type = addCheeseViewModel.Type
                };

                CheeseData.Add(cheese);

                return Redirect("/Cheese");
            }

            return View(addCheeseViewModel);
        }

        [HttpGet]
        public IActionResult DeleteCheckbox()
        {
            ViewBag.title = "Remove Cheeses with Checkboxes";
            ViewBag.cheeses = CheeseData.GetAll();
            return View();
        }

        [HttpGet]
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

        [HttpGet]
        public IActionResult Edit(int cheeseId)
        {
            ViewBag.title = "Edit Cheeses";
            ViewBag.cheese = CheeseData.GetById(cheeseId);
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Cheese cheese)
        {
            CheeseData.Remove(cheese.CheeseId);
            CheeseData.Add(cheese);

            return Redirect("/Cheese");
        }
    }
}
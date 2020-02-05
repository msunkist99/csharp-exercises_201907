using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MK_CheeseMVC.ViewModels
{
    public class AddCheeseViewModel
    {
        [Required(ErrorMessage ="You must enter a name for your cheese.")]
        [Display(Name="Cheese Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="You must add a description for your cheese.")]
        public string Description { get; set; }
    }
}

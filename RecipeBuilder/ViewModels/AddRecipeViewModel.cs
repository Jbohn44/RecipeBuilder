using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBuilder.ViewModels
{
    public class AddRecipeViewModel
    {

        [Required (ErrorMessage ="Please give your recipe a name")]
        [Display(Name = "Recipe Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please give your recipe instructions")]
        public string Instructions { get; set; }

        public List<SelectListItem> Ingredients { get; set; }


        

    }
}

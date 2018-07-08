using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipeBuilder.Models;
using RecipeBuilder.ViewModels;

namespace RecipeBuilder.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            IList<Recipe> recipes = new List<Recipe>();
            return View(recipes);
        }

        public IActionResult Add()
        {
            AddRecipeViewModel addRecipeViewModel = new AddRecipeViewModel();
            return View(addRecipeViewModel);
        }
    }
}
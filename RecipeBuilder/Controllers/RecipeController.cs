using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipeBuilder.Models;

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
            return View();
        }
    }
}
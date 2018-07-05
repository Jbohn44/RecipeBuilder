using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBuilder.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public IList<Ingredient> ingredients { get; set; }
        
        public string Instructions { get; set; }
    }
}

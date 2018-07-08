using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBuilder.Models
{
    //Ingredient Class.  May need to implement a weight/measurment property.  Could try to implement weight/measurment as an interface...
    public class Ingredient
    {
        public int ID { get; set; }
        public string Name { get; set; }
       
    }
}

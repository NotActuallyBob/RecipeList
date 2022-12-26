using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeListLibrary;

namespace RecipeListLibrary {
    public class Recipe {
        public int Key { get; set; }
        public string Name { get; set; }
        public float Cost { 
            get { return CalculateCost(); } 
        }
        public List<Ingrediant> Ingrediants { get; set; }
        public Recipe(int key, string title) {
            Key = key;
            Name = title;
            Ingrediants = new List<Ingrediant>();
        }
        public float CalculateCost() {
            float cost = 0;
            foreach (Ingrediant ingrediant in Ingrediants) {
                cost += ingrediant.Cost;
            }
            return cost;
        }
    }
}

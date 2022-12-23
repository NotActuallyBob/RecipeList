using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeList {
    public class Recipe {
        public int Key { get; set; }
        public string Name { get; set; }
        public float Cost { 
            get { return CalculateCost(); } 
        }
        public List<Tuple<Ingrediant, int>> Ingrediants { get; set; }
        public Recipe(int key, string title) {
            Key = key;
            Name = title;
            Ingrediants = new List<Tuple<Ingrediant,int>>();
            Ingrediants.Add(new Tuple<Ingrediant, int>(IngrediantManager.Get(0), 4));
            Ingrediants.Add(new Tuple<Ingrediant, int>(IngrediantManager.Get(1), 2));
        }
        public float CalculateCost() {
            float cost = 0;
            foreach (Tuple<Ingrediant, int> tuple in Ingrediants) {
                cost += tuple.Item1.Cost * tuple.Item2;
            }
            return cost;
        }
    }
}

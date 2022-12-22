using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeList {
    public static class IngrediantManager {
        private static Dictionary<string, Ingrediant> ingrediantDictionary = new Dictionary<string,Ingrediant>();
        public static bool AddIngrediant(string name, int cost) {
            if (ingrediantDictionary.ContainsKey(name)) {
                return false;
            }
            Ingrediant newIngrediant = new Ingrediant(name, cost);
            ingrediantDictionary.Add(name, newIngrediant);
            return true;
        }
        public static bool RemoveIngrediant(string name) {
            if (!ingrediantDictionary.ContainsKey(name)) {
                return false;
            }
            ingrediantDictionary.Remove(name);
            return true;
        }
    }
}

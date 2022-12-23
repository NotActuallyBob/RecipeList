using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeList {
    public static class RecipeManager {
        public static Dictionary<int, Recipe> recipeDictionary = new Dictionary<int, Recipe>();

        public static bool AddRecipe(string title) {
            int key = recipeDictionary.Count();
            Recipe newRecipe = new Recipe(key, title);
            recipeDictionary.Add(key, newRecipe);
            return true;
        }

        public static bool RemoveRecipe(int key) {
            recipeDictionary.Remove(key);
            return true;
        }

        public static List<Recipe> GetAll() {
            return recipeDictionary.Values.ToList();
        }
        public static List<Tuple<Ingrediant, int>> GetIngrediants(int key) {
            return recipeDictionary[key].Ingrediants;
        }
        public static string GetRecipeName(int key) {
            return recipeDictionary[key].Name;
        }
    }
}

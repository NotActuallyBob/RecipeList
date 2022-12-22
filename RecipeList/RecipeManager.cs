using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeList {
    public static class RecipeManager {
        private static Dictionary<string, Recipe> recipeDictionary = new Dictionary<string, Recipe>();

        public static bool AddRecipe(string title) {
            if (recipeDictionary.ContainsKey(title)) {
                return false;
            }
            Recipe newRecipe = new Recipe(title);
            recipeDictionary.Add(title, newRecipe);
            return true;
        }

        public static bool RemoveRecipe(string title) {
            if (!recipeDictionary.ContainsKey(title)) {
                return false;
            }
            recipeDictionary.Remove(title);
            return true;
        }
    }
}

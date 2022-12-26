using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeListLibrary;

namespace RecipeListLibrary {
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

        public static bool AddIngrediantToRecipe(int ingrediantKey, int recipeKey) {
            Ingrediant ingrediantToAdd = IngrediantManager.ingrediantDictionary[ingrediantKey];
            recipeDictionary[recipeKey].Ingrediants.Add(ingrediantToAdd);
            return true;
        }
        public static bool RemoveIngrediantFromRecipe(int ingrediantKey, int recipeKey) {
            Ingrediant ingrediantToRemove = IngrediantManager.ingrediantDictionary[ingrediantKey];
            recipeDictionary[recipeKey].Ingrediants.Remove(ingrediantToRemove);
            return true;
        }
    }
}

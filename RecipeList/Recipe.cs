using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeList {
    public class Recipe {
        public string Title { get; set; }
        public Recipe(string title) {
            Title = title;
        }
    }
}

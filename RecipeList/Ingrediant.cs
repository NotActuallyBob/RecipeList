using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeList {
    public class Ingrediant {
        public string Name { get; set; }
        public int Cost { get; set; }
        public Ingrediant(string name, int cost) {
            Name = name;
            Cost = cost;
        }
    }
}

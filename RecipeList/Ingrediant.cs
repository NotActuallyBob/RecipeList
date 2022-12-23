using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeList {
    public class Ingrediant {
        public string Name { get; set; }
        public int Key { get; set; }
        public float Cost { get; set; }
        public Ingrediant(int key, string name, float cost) {
            this.Key = key;
            this.Name = name;
            this.Cost = cost;
        }

    }
}

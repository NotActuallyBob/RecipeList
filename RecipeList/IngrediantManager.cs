using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeList {
    public static class IngrediantManager {
        static string saveFilePath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ProjectSaves", "RecipeList", "ingrediants");
        public static Dictionary<int, Ingrediant> ingrediantDictionary = new Dictionary<int,Ingrediant>();
        public static bool Add(string name, float cost) {
            int key = ingrediantDictionary.Count();
            Ingrediant newIngrediant = new Ingrediant(key, name, cost);
            ingrediantDictionary.Add(key, newIngrediant);
            return true;
        }
        public static bool Remove(int key) {
            ingrediantDictionary.Remove(key);
            return true;
        }

        public static List<Ingrediant> GetAll() {
            List<Ingrediant> list = ingrediantDictionary.Values.ToList();
            return list;
        }

        public static Ingrediant Get(int key) {
            return ingrediantDictionary[key];
        }

        public static void Save() {
            string[] lines = new string[ingrediantDictionary.Count()];
            foreach (int key in ingrediantDictionary.Keys) {
                Ingrediant ingrediant = ingrediantDictionary[key];
                lines[key] = key + ";" + ingrediant.Name + ";" + ingrediant.Cost + ";";
            }
            File.WriteAllLinesAsync(saveFilePath, lines);
        }

        public async static void Load() {
            if (!File.Exists(saveFilePath)) {
                return;
            }
            ingrediantDictionary.Clear();
            string[] lines = await File.ReadAllLinesAsync(saveFilePath);
            foreach (string line in lines) {
                string[] parameters = line.Split(';');
                int key = int.Parse(parameters[0]);
                string name = parameters[1];
                float cost = float.Parse(parameters[2]);
                ingrediantDictionary.Add(key, new Ingrediant(key, name, cost));
            }
        }
    }
}

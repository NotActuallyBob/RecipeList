using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RecipeList {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        List<Recipe> recipes = new List<Recipe>();
        public MainWindow() {
            InitializeComponent();
            recipes.Add(new Recipe("Hamburger", 10.0f));
            recipes.Add(new Recipe("Pizza", 20.0f));
            recipes.Add(new Recipe("Pasta", 5.0f));
            RecipeList.ItemsSource = recipes;
        }

        private void Button_CreateRecipe(object sender, RoutedEventArgs e) {
            recipes.Add(new Recipe(TitleTextBox.Text, float.Parse(CostTextBox.Text)));
            TitleTextBox.Text = "Title";
            CostTextBox.Text = "Cost";
            RecipeList.Items.Refresh();
        }

        private void Button_ModifyRecipe(object sender, RoutedEventArgs e) {
            string? toFind = ((Button)sender).Tag.ToString();
            if(toFind == null) {
                return;
            }

            ModifyWindow modifyWindow = new ModifyWindow();
            Recipe? r = recipes.Find(recipe => recipe.Title == toFind);

            if (r == null) {
                return;
            }
            modifyWindow.LoadRecipe(r);
            modifyWindow.Show();
        }
    }
    public class Recipe {
        public Recipe(string title, float cost) {
            Title = title;
            Cost = cost;
            ingrediants = new List<Ingrediant>();
        }
        public string Title { get; set; }
        public float Cost { get; set; }
        public List<Ingrediant> ingrediants;
    }
    public class Ingrediant {

    }
}

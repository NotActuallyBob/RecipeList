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
using System.Windows.Shapes;
using RecipeListLibrary;

namespace RecipeList {
    /// <summary>
    /// Interaction logic for ModifyRecipeWindow.xaml
    /// </summary>
    public partial class ModifyRecipeWindow : Window {
        int recipeKey;
        public ModifyRecipeWindow(Recipe recipe) {
            recipeKey = recipe.Key;
            InitializeComponent();
            RecipeNameTextBlock.Text = recipe.Name;
            PopulateListBoxes();
        }

        private void Button_AddIngrediant(object sender, RoutedEventArgs e) {
            Button button = (Button)sender;
            string tag = button.Tag.ToString();
            int ingrediantKey = int.Parse(tag);

            RecipeManager.AddIngrediantToRecipe(ingrediantKey, recipeKey);
            PopulateListBoxes();
        }

        private void Button_RemoveIngrediant(object sender, RoutedEventArgs e) {
            Button button = (Button)sender;
            string tag = button.Tag.ToString();
            int ingrediantKey = int.Parse(tag);

            RecipeManager.RemoveIngrediantFromRecipe(ingrediantKey, recipeKey);
            PopulateListBoxes();
        }


        private void PopulateListBoxes() {
            UIHelper.PopulateListBox(IngrediantsNotUsedBox, IngrediantManager.GetIngrediantsNotUsed(recipeKey));
            UIHelper.PopulateListBox(IngrediantsUsedBox, IngrediantManager.GetIngrediantsUsed(recipeKey));
        }
    }
}

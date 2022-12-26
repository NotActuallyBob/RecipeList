using RecipeListLibrary;
using System;
using System.Windows;
using System.Windows.Controls;

namespace RecipeList {
    /// <summary>
    /// Interaction logic for PageRecipes.xaml
    /// </summary>
    public partial class PageRecipes : Page {
        public PageRecipes() {
            InitializeComponent();
            RecipeList.ItemsSource = RecipeManager.recipeDictionary.Values;
        }
        private void Button_CreateRecipe(object sender, RoutedEventArgs e) {
            RecipeManager.AddRecipe(TitleTextBox.Text);
            TitleTextBox.Text = "Title";
            RecipeList.Items.Refresh();
        }

        private void Button_ModifyRecipe(object sender, RoutedEventArgs e) {
            Button senderButton = (Button)sender;
            string? recipeKeyString = senderButton.Tag.ToString();
            int recipeKeyInt = -1;
            try {
                recipeKeyInt = int.Parse(recipeKeyString);
            } catch {
            }
            Recipe recipeToModify = RecipeManager.recipeDictionary[recipeKeyInt];
            ModifyRecipeWindow modifyRecipeWindow = new ModifyRecipeWindow(recipeToModify);
            modifyRecipeWindow.Show();
        }
    }
}

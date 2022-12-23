using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    }
}

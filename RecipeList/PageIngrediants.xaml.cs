using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Diagnostics;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace RecipeList {
    /// <summary>
    /// Interaction logic for PageIngrediants.xaml
    /// </summary>
    public partial class PageIngrediants : Page {
        public PageIngrediants() {
            InitializeComponent();
            IngrediantList.ItemsSource = IngrediantManager.ingrediantDictionary.Values;
        }

        private void CheckNumbers(object sender, TextCompositionEventArgs e) {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_CreateIngrediant(object sender, RoutedEventArgs e) {
            IngrediantManager.Add(TitleTextBox.Text, 1000);
            TitleTextBox.Text = "Title";
            IngrediantList.Items.Refresh();
        }

    }
}

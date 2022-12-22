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

namespace RecipeList {
    /// <summary>
    /// Interaction logic for ModifyWindow.xaml
    /// </summary>
    public partial class ModifyWindow : Window {
        private Recipe RecipeToModify;
        public ModifyWindow() {
            InitializeComponent();
        }

        public void LoadRecipe(Recipe r) {
            RecipeToModify = r;
            NameTextBox.Text = RecipeToModify.Title;
        }
    }
}

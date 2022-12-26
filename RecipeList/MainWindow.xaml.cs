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
using RecipeListLibrary;
using Path = System.IO.Path;
using Directory = System.IO.Directory;

namespace RecipeList {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private string saveFolderPath;
        public MainWindow() {
            InitializeComponent();
            Main.Content = new PageIngrediants();
            CreateSaveFolder();
            LoadContent();
        }


        private void Button_GoToRecipes(object sender, RoutedEventArgs e) {
            Main.Content = new PageRecipes();
        }
        private void Button_GoToIngrediants(object sender, RoutedEventArgs e) {
            Main.Content = new PageIngrediants();
        }
        private void Button_Save(object sender, RoutedEventArgs e) {
            IngrediantManager.Save();
        }
        private void CreateSaveFolder() {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string documentsPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string projectSavesPath = Path.Combine(documentsPath, "ProjectSaves");
            saveFolderPath = Path.Combine(projectSavesPath, "RecipeList");
            Directory.CreateDirectory(projectSavesPath);
            Directory.CreateDirectory(saveFolderPath);
        }
        private void LoadContent() {
            IngrediantManager.Load();
        }

        /*private void Button_ModifyRecipe(object sender, RoutedEventArgs e) {
            string? toFind = ((Button)sender).Tag.ToString();
            if(toFind == null) {
                return;
            }

            ModifyWindow modifyWindow = new ModifyWindow();
            Recipe? r = RecipeManager.GetAll().Find(recipe => recipe.Title == toFind);

            if (r == null) {
                return;
            }
            modifyWindow.LoadRecipe(r);
            modifyWindow.Show();
        }*/
    }
}

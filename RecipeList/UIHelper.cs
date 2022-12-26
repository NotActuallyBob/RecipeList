using System.Collections.Generic;
using System.Windows.Controls;

namespace RecipeList {
    public static class UIHelper {
        public static bool PopulateListBox<T>(ListBox listBox, List<T> list) {
            listBox.Items.Clear();
            foreach (T item in list) {
                listBox.Items.Add(item);
            }
            return true;
        }
    }
}

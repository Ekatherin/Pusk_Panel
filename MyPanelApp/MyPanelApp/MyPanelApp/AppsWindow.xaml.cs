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

namespace MyPanelApp
{
    /// <summary>
    /// Interaction logic for AppsWindow.xaml
    /// </summary>
    public partial class AppsWindow : Window
    {
        public AppsWindow()
        {
            InitializeComponent();
            DataContext = Core.VM;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var a = new Data.Application();

            a.Title = AppTitle.Text;
            a.FilePath = AppFilePath.Text;
            a.ImagePath = AppImageFilePath.Text;
            a.ApplicationCategory = AppCategoryCombobox.SelectedItem as Data.ApplicationCategory;

            Core.DB.Application.Add(a);

            Core.DB.SaveChanges();

            Core.VM.Applications.Add(a);
        }
    }
}

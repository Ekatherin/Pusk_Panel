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

namespace MyPanelApp.Pages
{
    /// <summary>
    /// Interaction logic for PageApplicationCategoryApplicationVer2.xaml
    /// </summary>
    public partial class PageApplicationCategoryApplicationVer2 : Page
    {
        public PageApplicationCategoryApplicationVer2()
        {
            InitializeComponent();
            this.DataContext = Core.VM;
        }

        private void AppEditNew_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CatEditNew_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (sender as DataGrid).SelectedItem;
            var app = item as Data.Application;


            var editPage = new PageAppEditNew(app);

            NavigationService.Navigate(editPage);
        }

        private void CategoriesGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var item = (sender as DataGrid).SelectedItem;
            //var app = item as Data.ApplicationCategory;


            //var editPage = new PageCatEditNew(app);

            //NavigationService.Navigate(editPage);
        }
    }
}

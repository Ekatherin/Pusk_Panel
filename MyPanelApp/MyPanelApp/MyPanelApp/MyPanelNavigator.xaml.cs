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
    /// Interaction logic for MyPanelNavigator.xaml
    /// </summary>
    public partial class MyPanelNavigator : Window
    {
        public MyPanelNavigator()
        {
            InitializeComponent();
            Core.VM.Applications = Core.DB.Application.ToList();
            Core.VM.ApplicationCategories = Core.DB.ApplicationCategory.ToList();

            DataContext = Core.VM;
        }

        private void MainShow(object sender, RoutedEventArgs e)
        {
            var mw = new MainWindow();
            mw.ShowDialog();
        }

        private void PageAppShow(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Pages.PageApplication());
           
        }

        private void PageCatAppShow(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Pages.PageApplicationCategory());
           
        }

        private void PageCatCatAppShow(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Pages.PageApplicationCategoryApplication());
        }

        private void PageCatCatAppShowVer2(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Pages.PageApplicationCategoryApplicationVer2());
        }
    }
}

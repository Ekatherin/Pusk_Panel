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

namespace MyPanelApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var categories = new List<Model.ApplicationCategory>()
            {
                new Model.ApplicationCategory() {Title = "Office"},
                new Model.ApplicationCategory() {Title = "Media"}
            };

            List<Model.Application> apps = new List<Model.Application>();
            apps.Add(new Model.Application() { Title = "First", FilePath="PathFirst", Category=categories[0]});
            apps.Add(new Model.Application() { Title = "Second", FilePath = "PathSecond", Category = categories[1] });
            apps.Add(new Model.Application() { Title = "Third", FilePath = "PathThird", Category = categories[0] });
            apps.Add(new Model.Application() { Title = "Fourth", FilePath = "PathFourth", Category = categories[0] });


            AppsListView.ItemsSource = apps;
        }

        private void AppsBtn_Click(object sender, RoutedEventArgs e)
        {
            var p = new AppsWindow();
            p.ShowDialog();
        }
    }
}

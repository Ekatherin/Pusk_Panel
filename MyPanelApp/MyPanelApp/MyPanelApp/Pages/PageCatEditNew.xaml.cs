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
    /// Interaction logic for PageCatEditNew.xaml
    /// </summary>
    public partial class PageCatEditNew : Page
    {
        public PageCatEditNew(Data.ApplicationCategory app)
        {
            InitializeComponent();
            App = app;
            this.DataContext = this;
        }

        public Data.ApplicationCategory App { get; set; }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (App.Id == 0)
            {
                
                Core.DB.ApplicationCategory.Add(App);
            }

            Core.DB.SaveChanges();
        }
    }
}

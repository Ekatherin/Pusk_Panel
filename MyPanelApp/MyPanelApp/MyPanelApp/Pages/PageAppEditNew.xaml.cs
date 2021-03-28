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
    /// Interaction logic for PageAppEditNew.xaml
    /// </summary>
    public partial class PageAppEditNew : Page
    {
        public PageAppEditNew(Data.Application app)
        {
            InitializeComponent();
            App = app;
            this.DataContext = this;
        }

        public Data.Application App { get; set; }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (App.id == 0)
            {
                App.ApplicationCategoryId = 2;
                Core.DB.Application.Add(App);
            }

               Core.DB.SaveChanges();
        }
    }
}

﻿using System;
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
    }
}

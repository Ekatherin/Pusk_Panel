using MyPanelApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPanelApp
{
    class Core
    {
        public static MyPanelEntities DB = new MyPanelEntities();
        public static ViewModel VM = new ViewModel();
    }
}

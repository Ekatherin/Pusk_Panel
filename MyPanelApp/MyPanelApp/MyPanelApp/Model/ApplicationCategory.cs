using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPanelApp.Model
{
    class ApplicationCategory
    {
        public String Title { get; set; }
        public String Description { get; set; }

        public override string ToString()
        {
            return this.Title;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStartMenu.Model
{
    class Application
    {
        
        public ApplicationCategory Category { get; set; }
        public String FilePath { get; set; }
        
        public String Title
        {
            get;set;
        }
        public String ImageFilePath { get; set; }




        //public String Name { get; set; }
        //public String Surname { get; set; }
        //public String Patronymic { get; set; }

        //public String FullName { get =>this.Name + " " + this.Patronymic; }

        //public override string ToString()
        //{
            

        //    return this.Title;
        //}
    }
}

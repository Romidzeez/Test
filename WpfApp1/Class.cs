using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Class
    {
        private int Id_Class{ get; set; }
        private int Year_Of_Education;
        private string Class_letter;

        public Class() { }

        public Class(int id_Class, int Year_Of_Education, string Class_Letter)
        {
            this.Id_Class = id_Class;
            this.Year_Of_Education = Year_Of_Education;
            this.Class_letter = Class_Letter;
        }
    }
}

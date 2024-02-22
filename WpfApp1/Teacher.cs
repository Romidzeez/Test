using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Teacher
    {
        private int Id_Teacher { set; get; }
        private string Full_Name;
        private int Date_Of_birt;

        public Teacher() { }
        
        public Teacher(int Id_Teacher, string Full_Name, int Date_Of_birt)
        {
            this.Id_Teacher= Id_Teacher;
            this.Full_Name= Full_Name;
            this.Date_Of_birt= Date_Of_birt;
        }

    }
}

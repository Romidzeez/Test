using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Classroom
    {
        private int Id_Classroom { get; set; }
        private int Year_Of_Education;
        private string Class_Letter;

        public Classroom() { 
        
        }

        public Classroom(int Id_Classroom, int Year_OF_Education, string Class_Letter)
        {
            this.Id_Classroom = Id_Classroom;
            this.Year_Of_Education = Year_OF_Education;
            this.Class_Letter = Class_Letter;
        }
						// каждая таблица как отдельный класс и файл дальше создадим mvc model view system 

    }
}

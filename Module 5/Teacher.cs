using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Homework
{
    class Teacher
    {
        

        // private variables declaration
        private string tName;
        private string tLastName;
        private string clName;
       


        public Teacher()
        {
        }

        // constructor
        public Teacher(string TeacherName, string TeacherLastName, string ClassName)
        {
            this.tName = TeacherName;
            this.tLastName = TeacherLastName;
            this.clName = ClassName;
        }

        // properties
        public string TName{get; set;}
        public string TLastName { get; set;}
        public string ClName { get; set; }

        
    }
}

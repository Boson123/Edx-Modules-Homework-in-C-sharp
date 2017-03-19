using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M7Homework
{
    class Teacher : Person
    {

        //properties
        public Student Obj{get; set;}
        public string Grade { get; set; }

        //constructor
        public Teacher(string FirstN, string LastN, string className)
        {
            this.Name = FirstN;
            this.Lastname = LastN;
            this.Class = className;
          
        }

        // teacher's methods
        public void GradeTest(Student student, int grade)
        {
            this.Obj = student;
            this.Grade = grade.ToString();
            Console.WriteLine("Teacher {0} {1} graded the {2} {3} as {4}", this.Name,this.Lastname,this.Obj.Name,this.Obj.Lastname,this.Grade);
        }
        
    }
}

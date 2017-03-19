using System;
using System.Collections; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M7Homework
{
    class Student : Person, IComparable
    {


        //variables


        // Create a Stack object inside the Student object, called Grades, to store test scores.
        private Stack grades = new Stack();
        public Stack Grades { get { return grades; }set { grades = value; } }

       

    //constructor
        public Student(string FirstN, string LastN, string AdressL1,string AdressL2, string Ci, string Pr, string Zip, string Count, DateTime BD)
        {
            this.Name = FirstN;
            this.Lastname = LastN;
            this.AdressLine1 = AdressL1;
            this.AdressLine2 = AdressL2;
            this.City = Ci;
            this.State_Province = Pr;
            this.Zip_Postal = Zip;
            this.Country = Count;
            this.BirthDate = BD;
            
        }
        //method definition to iterate over the student collection and output the first and last name 
        //along with each of the 5 grades for that student.
        public void listAllGradesforStudent()
        {              
            string studentgrades = "  ";
            foreach (int gr in this.grades)
            {
                studentgrades += gr.ToString() + "  ";
                
            }
            Console.WriteLine("Grades for student {0} {1} are : {2}  "  ,this.Name,this.Lastname, studentgrades);
        }
     

        // Student's methods 
        public void TestPassed(int credit)
        {
            if (credit >= 10)
                Console.WriteLine("student {0} {1} past test succesfully from  math", this.Name, this.Lastname);
            else
                Console.WriteLine("student {0} {1} didn't pass test from  math", this.Name, this.Lastname);
        }

        public int CompareTo(object obj)
        {
            Student studentCompared = (Student)obj;
            string nameComapred = studentCompared.Name;
            string name = this.Name;
            return (name.CompareTo(nameComapred));

           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6Homework
{
    class Student : Person
    {   
        
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

        // Student's methods 
        public void TestPassed(int credit)
        {
            if (credit >= 10)
                Console.WriteLine("student {0} {1} past test succesfully from  math", this.Name, this.Lastname);
            else
                Console.WriteLine("student {0} {1} didn't pass test from  math", this.Name, this.Lastname);
        }

    }
}

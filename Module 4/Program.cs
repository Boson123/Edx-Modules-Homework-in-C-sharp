using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating the objects st1,st2,st3 of student's struct
            //and passing the values hrough constructor

            student st1 = new student("Peter", "Walker");
            student st2 = new student("Michael", "Jordan");
            student st3 = new student("Marta", "Star");

            //  creating an array containing 5 structs of student's type 
            student[] array = new student[5];
            
            // assignement the objects of students in to array's values
            array[0] = st1;
            array[1] = st2;
            array[2] = st3;

            // desplaying the properties of students objects
            Console.WriteLine(" The first student is {0} {1}", st1.v1, st1.v2);
            Console.WriteLine(" The second student is {0} {1}", array[1].v1, st2.v2);
            Console.WriteLine(" The third student is {0} {1}", array[2].v1, st3.v2);
            Console.ReadKey();

        }

        // declarations of structures
        struct student
        {
            public string v1;
            public string v2;

            public student(string v1, string v2)
            {
                this.v1 = v1;
                this.v2 = v2;
            }
        }

        struct teacher
        {
            public string Name, Surname;
        }
        struct uprogram
        {
            public string Name, Location, profName;
        }

        struct course
        {
            public string Name;
        }

        

    }
}

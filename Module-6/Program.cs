using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // instantiate 3 Student objects.

            Student s1 = new Student("Thomas", "Walker", "8", "Churchill Street", "London", "Greater London", "E152SA", "England", new DateTime(1973,03,29));
            Student s2 = new Student("Mark","Walcat","4","Moon Rd","Redditch","Greater London","RT453" , "England",new DateTime(1982,11,03));
            Student s3 = new Student("Adam","Bolek","5","Wide Rd", "Leeds", "West Yorkshire", "LE356", "England" , new DateTime(2003,01,01));
            
            
            // instantiate the Course object called Programming with C# 

            Course c1 = new Course("Programming with C#");
            //Course c2 = new Course("English");
            //Course c3 = new Course("French");

            // add 3 Students to this Course object.

            c1.addStudents(s1);
            c1.addStudents(s2);
            c1.addStudents(s3);
            //c1.addStudents(s4);

            // Instantiate at least one Teacher object 

            Teacher t1 = new Teacher("John", "Fire", "B2");
            Teacher t2 = new Teacher("Adam", "Layer", "B3");
            Teacher t3 = new Teacher("Barbara", "Soja","B1");

            // Add that Teacher object to your Course object

            c1.addTeachers(t1);
            c1.addTeachers(t2);
            c1.addTeachers(t3);
       

            // Instantiate a Degree object, such as Bachelor.

            Degree d1 = new Degree("Bachelor");
            //Degree d2 = new Degree("HND");

            // Add your Course object to the Degree object.

            d1.addCourse(c1);
            //d1.addCourse(c2);
            //d1.addCourse(c3);

           
            // Instantiate a UProgram object called Information Technology.

            Uprogram Up1 = new Uprogram("Information Technology");

            // Add the Degree object to the UProgram object.

            Up1.addUprogram(d1);

            //Using Console.WriteLine statements, output the following information to the console window:

            //The name of the program and the degree it contains

            Console.WriteLine("The {0} program contains the {1} of science degree", Up1.Title,d1.DegName);

            //The name of the course in the degree

            Console.WriteLine("The {0} of science degree contains the course {1} ", d1.DegName, c1.Coursename);

            //The count of the number of students in the course.

            Console.WriteLine("The {0} course contains {1} student(s)", c1.Coursename, c1.CurrentStudentNumber);

            // The count of the number of teachers in the course
            //Console.WriteLine("The {0} course contains {1} teacher(s)", c1.Coursename, c1.CurrentTeacherNumber);

            // testing of teacher's details
            Console.WriteLine("The name of second teacher is: {0}, surname is: {1} and class he/she teaches {2}", t2.Name, t2.Lastname, t2.Class);

            // Modify your Student and Teacher classes so they include characteristics specific to their 
            //type.  For example, a Teacher object might have a GradeTest() method where a student might have a TakeTest() method.

            // who passed the test ?
            s2.TestPassed(8);

            // which teacher graded which student and what was the grade ?
            t2.GradeTest(s1, 4);


            // Challenge

            // Create an instance of a Person object in code
            Person alien = new Person();

            //Create an instance of a Student object in code
            Student strangeStudent = new Student("Ali", "Baba", "5 Cross", "Okengate", "London", "Grate London", "EL768", "England", new DateTime(1872,07,01));

            //Assign the Student object to the Person object
            alien = strangeStudent;

            //Access the properties of the Person instance you created
            Console.WriteLine("Unknown new strange person is {0} {1}", alien.Name,alien.Lastname);

            

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

    }
}

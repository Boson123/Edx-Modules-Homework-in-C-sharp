using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M7Homework
{

    class Course
    {

        // private variables
        private string coursename;        
        private int currentStudentNumber = 0;
        private static int maxNumberofStudents = 3;
        private Teacher teach;
        private int currentTeacherNumber = 0;
        private static int maxNumberofTeachers = 3;

        // arrays for keeping students and teachers
        //Create an ArrayList to replace the array and to hold students, inside the Course object.      
        ArrayList students = new ArrayList();


        Teacher[] NumOfTeacher = new Teacher[maxNumberofTeachers];

        //propperties

        public string Coursename { get { return coursename; } set { coursename = value; } }
        public int CurrentStudentNumber { get { return currentStudentNumber; } set { currentStudentNumber = value; } }
        public int MaxNumberofStudents { get { return maxNumberofStudents; } set { maxNumberofStudents = value; } }        // constructors
        public int CurrentTeacherNumber { get { return currentTeacherNumber; } set { currentTeacherNumber = value; } }
        public int MaxNumberofTeachers { get { return maxNumberofTeachers; } set { maxNumberofTeachers = value; } }
        public ArrayList Students { get { return students; } set { students = value; } }

        // constructor
        public Course(string cName)
        {
            this.coursename = cName;
        }

        // addstudents method
        public void addStudents(Student student)
        {
            try
            {
                //Modify your code to use the ArrayList collection as the replacement to the array.  
                //In other words, when you add a Student to the Course object, 
                //you will add it to the ArrayList and not an array.
                students.Add(student);
                this.currentStudentNumber++;
            }
            catch (IndexOutOfRangeException)
            {

                Console.WriteLine("sorry you have added to many students to your course, the max number of students is : {0} ", this.MaxNumberofStudents);
                Console.WriteLine("Close this console application by pressing any key and insert the correct number of students");
                Console.ReadKey();
                Environment.Exit(0);
            }


        }

        // addTeachers method
        public void addTeachers(Teacher teacher)
        {

            try
            {
                this.teach = teacher;
                NumOfTeacher[currentTeacherNumber] = teach;
                this.currentTeacherNumber++;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("the number of added teachers to this course is to big, the max number of teachers is : {0}", this.MaxNumberofTeachers);
                Console.WriteLine("Close this console application by pressing any key and insert the correct number of teachers");
                Console.ReadKey();
                Environment.Exit(0);
            }


        }

        // Using an appropriate loop to iterate over the Students in the ArrayList 
        // and output their first and last names to the console window.
        // (For this exercise you MUST cast the returned object from the ArrayList to a Student object. 
        // Also, place each student name on its own line)


        // Create a method inside the Course object called ListStudents() that contains the foreach loop.

        public void ListStudents()
        {
            foreach (object obj in students)
            {

                Console.WriteLine(" First Name : {0} , Last Name : {1}", ((Student)obj).Name, ((Student)obj).Lastname);
            }
        }

        //Sort the ArrayList of students.
        public void sortallStudents()
        {
            students.Sort() ;
        }

        // Use a foreach loop to output the student names to see if the sort performed what you expect.
        public void ListSortedStudents()
        { 

            foreach(object obj in students)
            {
            Console.WriteLine(" First Name : {0} , Last Name : {1}", ((Student)obj).Name, ((Student)obj).Lastname );
            }
        }
    }
}

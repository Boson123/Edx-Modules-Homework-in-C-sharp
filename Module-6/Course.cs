using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6Homework
{

    class Course
    {

        // private variables
        private string coursename;
        private Student stud;
        private int currentStudentNumber = 0;
        private static int maxNumberofStudents = 3;
        private Teacher teach;
        private int currentTeacherNumber = 0;
        private static int maxNumberofTeachers = 3;

        // arrays for keeping students and teachers
        Student[] NumOfStudent = new Student[maxNumberofStudents];
        Teacher[] NumOfTeacher = new Teacher[maxNumberofTeachers];

        //propperties

        public string Coursename {get { return coursename; } set{ coursename = value; } }
        public int CurrentStudentNumber { get { return currentStudentNumber; } set { currentStudentNumber = value; } }
        public int MaxNumberofStudents { get { return maxNumberofStudents; } set { maxNumberofStudents = value; } }        // constructors
        public int CurrentTeacherNumber { get { return currentTeacherNumber; } set { currentTeacherNumber = value; } }
        public int MaxNumberofTeachers { get { return maxNumberofTeachers; } set { maxNumberofTeachers = value; } }

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
                this.stud = student;
                NumOfStudent[currentStudentNumber] = stud;
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
                Console.WriteLine("the number of added teachers to this course is to big, the max number of teachers is : {0}" , this.MaxNumberofTeachers);
                Console.WriteLine("Close this console application by pressing any key and insert the correct number of teachers");
                Console.ReadKey();
                Environment.Exit(0);
            }
            
           
        }

        
    }
}

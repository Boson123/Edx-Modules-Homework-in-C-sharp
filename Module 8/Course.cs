using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M8Homework
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


//Create a List<T>, of the proper data type, to replace the ArrayList and to hold students, inside the Course object.
List<Student> students = new List<Student>();

Teacher[] NumOfTeacher = new Teacher[maxNumberofTeachers];

//propperties

public string Coursename { get { return coursename; } set { coursename = value; } }
public int CurrentStudentNumber { get { return currentStudentNumber; } set { currentStudentNumber = value; } }
public int MaxNumberofStudents { get { return maxNumberofStudents; } set { maxNumberofStudents = value; } } // constructors
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
// Modify your code to use the List<T> collection as the replacement to the ArrayList.
//In other words, when you add a Student to the Course object,
//you will add it to the List<T> and not an array ArrayList.
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

//Using a foreach loop, iterate over the Students in the List<T>
//and output their first and last names to the console window.
//(For this exercise, casting is no longer required.Also, place each student name on its own line)

// Create a method inside the Course object called ListStudents() that contains the foreach loop.
// Modify your code to use the List<T> collection as the replacement to the ArrayList.
public void ListStudents()
{
foreach (Student obj in students)
{

Console.WriteLine(" First Name : {0} , Last Name : {1}", obj.Name, obj.Lastname);
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

foreach(Student obj in students)
{
Console.WriteLine(" First Name : {0} , Last Name : {1}", obj.Name, obj.Lastname );
}
}
}
}

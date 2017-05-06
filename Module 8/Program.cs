Program.cs
-----------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M8Homework
{
class Program
{

static void Main(string[] args)
{

// instantiate 3 Student objects (Create 3 student objects).

Student s1 = new Student("Thomas", "Walker", "8", "Churchill Street", "London", "Greater London", "E152SA", "England", new DateTime(1973,03,29));
Student s2 = new Student("Mark","Walcat","4","Moon Rd","Redditch","Greater London","RT453" , "England",new DateTime(1982,11,03));
Student s3 = new Student("Adam","Bolek","5","Wide Rd", "Leeds", "West Yorkshire", "LE356", "England" , new DateTime(2003,01,01));

// Add 5 grades to the the Stack<T> in the each Student object.
// (this does not have to be inside the constructor because
// you may not have grades for a student when you create a new student.)

s1.Grades.Push(1);
s1.Grades.Push(2);
s1.Grades.Push(3);
s1.Grades.Push(4);
s1.Grades.Push(5);

s2.Grades.Push(1);
s2.Grades.Push(2);
s2.Grades.Push(3);
s2.Grades.Push(4);
s2.Grades.Push(5);

s3.Grades.Push(1);
s3.Grades.Push(2);
s3.Grades.Push(3);
s3.Grades.Push(4);
s3.Grades.Push(5);

// instantiate the Course object called Programming with C#

Course c1 = new Course("Programming with C#");
//Course c2 = new Course("English");
//Course c3 = new Course("French");

// Add the three Student objects to the List<T> inside the Course object.
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
//type. For example, a Teacher object might have a GradeTest() method where a student might have a TakeTest() method.

// who passed the test ?
s2.TestPassed(8);

// which teacher graded which student and what was the grade ?
t2.GradeTest(s1, 4);

// Challenge
Console.WriteLine(" \n Challenge for module 6 **************\n");

// Create an instance of a Person object in code
Person alien = new Person();

//Create an instance of a Student object in code
Student strangeStudent = new Student("Ali", "Baba", "5 Cross", "Okengate", "London", "Grate London", "EL768", "England", new DateTime(1872,07,01));

//Assign the Student object to the Person object
alien = strangeStudent;

//Access the properties of the Person instance you created
Console.WriteLine("Unknown new strange person is {0} {1} \n", alien.Name,alien.Lastname);

//testing the students details from ArrayList
Console.WriteLine("The second student is : {0} {1} ", s2.Name, s2.Lastname );
Console.WriteLine("The first student is : {0} {1} ", s1.Name, s1.Lastname);

// Module 8 starts here

Console.WriteLine(" Module 8 starts here : ***************** \n");

//Call the ListStudents() method from Main().
c1.ListStudents();

//challenge

Console.WriteLine(" \nChallenge for module 8 starts here ************* \n");

//Sort the ArrayList of students in course.
c1.sortallStudents();

Console.WriteLine("\n");

// output the student names to see if the sort performed what you expect.
c1.ListSortedStudents();

//To simulate changing a grade for a student,
//remove the last entered grade and replace it with a new one.
s1.Grades.Pop();
s1.Grades.Push(8);

//Bonus challenge: Ensure you have added at least 5 grades to the stack.
//Replace the third grade in the stack without losing the two grades above it.
int grade5 = s1.Grades.Pop();
int grade4 = s1.Grades.Pop();
s1.Grades.Pop();
s1.Grades.Push(7);
s1.Grades.Push(grade4);
s1.Grades.Push(grade5);

//Iterate over the student collection and output the first and last name
//along with each of the 5 grades for that student.

s1.listAllGradesforStudent();
s2.listAllGradesforStudent();

Console.WriteLine("Press any key to exit");
Console.ReadKey();
}

}
}

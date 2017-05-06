using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mod_9_Homework
{
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
// variable to increment student's
int CurrentStudent = -1;

// Create a collection to store Student objects (Use a List<T> for this assignment)
List<Student> students = new List<Student>();

// Add a new class to the project to represent a Student with
// three properties for the text fields.
class Student
{

// properties
public string Name { get; set; }
public string LastName { get; set; }
public string City { get; set; }

// constructor
public Student(string sName, string sLastName, string sCity)
{
this.Name = sName;
this.LastName = sLastName;
this.City = sCity;
}
}

//------------------------------------------------------------------
public MainWindow()
{
InitializeComponent();
}
//------------------------------------------------------------------

// Implement the code in the button click event handler to create a Student object
private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
{

string Fname = txtFirstName.Text;
string Lname= txtLastName.Text;
string City = txtCity.Text;
Student st = new Student(Fname,Lname,City);
// and add it to the collection
students.Add(st);
CurrentStudent++;
// Clear the contents of the text boxes in the event handler
// textbox.Text = ""; or textbox.Clear();
txtFirstName.Clear();
txtLastName.Clear();
txtCity.Clear();

}
//There are two additional buttons on the form that can be used
//to move through a collection of students, (previous (<) and next (>) ).
//Create event handlers for each of these buttons that will iterate over your
//Students collection and display the values in the text boxes
private void btnNext_Click(object sender, RoutedEventArgs e)
{
CurrentStudent++;
if (CurrentStudent >= 0 && CurrentStudent < students.Count)
DisplayStudentsData();
else
{
//Search on the properties of the buttons to learn how to disable the buttons
//if you are at the beginning or end of the collection.
//Doing this prevents an unhandled exception if the button click attempts
//to access a value in the collection past the end or beginning.
btnNext.IsEnabled = false;
}
btnPrevious.IsEnabled = true;
}

private void btnPrevious_Click(object sender, RoutedEventArgs e)
{
CurrentStudent--;
if (CurrentStudent >= 0 && CurrentStudent < students.Count)
DisplayStudentsData();
else
{
btnPrevious.IsEnabled = false;
}
btnNext.IsEnabled = true;
}

public void DisplayStudentsData()
{
txtFirstName.Text = students[this.CurrentStudent].Name;
txtLastName.Text = students[this.CurrentStudent].LastName;
txtCity.Text = students[this.CurrentStudent].City;
}
}
}

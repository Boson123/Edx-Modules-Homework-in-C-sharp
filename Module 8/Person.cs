using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M8Homework
{
class Person
{
//private variable
private string name;
private string lastname;

//properties
public string Name { get { return name; } set { name = value; } }
public string Lastname { get { return lastname; } set { lastname = value; } }
public string AdressLine1 { get; set; }
public string AdressLine2 { get; set; }
public string City { get; set; }
public string State_Province { get; set; }
public string Zip_Postal { get; set; }
public string Country { get; set; }
public DateTime BirthDate { get; set; }
public string Class { get; set; }


}
}

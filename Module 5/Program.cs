using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables declaration
            string FirstName,LastName, AdressLine1, AdressLine2, City, State_Province, Zip_Postal, Country;
            DateTime BirthDate;
            int year,month,day;

            // assignements values to variables
            BirthDate = new DateTime(1965,3,25);
            FirstName = "Marcin";
            LastName = "Winner";
            AdressLine1 = "7";
            AdressLine2 = "Churchil Street";
            City = "London";
            State_Province = "Croydon";
            Zip_Postal = "Lo65GD";
            Country = "England";

            // first output the values to the console window
            Console.WriteLine(FirstName + " " + LastName + " is living at " + AdressLine1 + " " + AdressLine2 + " " + City +" " + Zip_Postal +"\n");
            

            //Challenge - using of Console.ReadLine();

            //accepting inputs from user
            Console.Write("Insert your First Name ? ");
            FirstName = Console.ReadLine();
            //Console.Write("Your name is : " + s + "\n");

            Console.Write("Insert your Last Name ? ");
            LastName = Console.ReadLine();
            //Console.Write("Your surname is : " + b + "\n");
            Console.Write("Insert your AdressLine1 ? ");
            AdressLine1 = Console.ReadLine();
            Console.Write("Insert your AdressLine2 ? ");
            AdressLine2 = Console.ReadLine();
            Console.Write("Insert your City ? ");
            City = Console.ReadLine();
            Console.Write("Insert your ZipPostal ? ");
            Zip_Postal = Console.ReadLine();
            Console.Write("Insert the year of your birth ? ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Insert the month of your birth ? ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Insert the day of your birth ? ");
            day = int.Parse(Console.ReadLine());
            BirthDate = new DateTime(year,month,day);
            //Console.Write("your date of birth is :" + BirthDate);

            //desplaying accepted datas from user.
            Console.WriteLine(FirstName + " " + LastName + " lives on " + AdressLine1 + " " + AdressLine2 + "\n " + Zip_Postal + " \n and he was born in \n" + BirthDate);
            Console.ReadLine();

        }
    }
}

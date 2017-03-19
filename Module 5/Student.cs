using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Homework
{
    class Student
    {

        //variables
        
        private string firstname;
        private string lastname;
        private string adressLine1;
        private string adressLine2;
        private string city;
        private string state_Province;
        private string zip_Postall;
        private string country;
        private DateTime birthdate;
        
        
      
        //properties

        public string FirstName { get; set; }
       
        public string LastName { get; set; }

        public string AdressLine1 { get; set; }

        public string AdressLine2 { get; set; }

        public string City { get; set; }

        public string State_Province { get; set; }

        public string Zip_Postal { get; set; }

        public string Country { get; set; }

        public DateTime BirthDate {get; set;}

        //constructor

        public Student(string FirstN, string LastN, string AdressL1,string AdressL2, string Ci, string Pr, string Zip, string Count, DateTime BD)
        {
            this.firstname = FirstN;
            this.lastname = LastN;
            this.adressLine1 = AdressL1;
            this.adressLine2 = AdressL2;
            this.city = Ci;
            this.state_Province = Pr;
            this.zip_Postall = Zip;
            this.country = Count;
            this.birthdate = BD;
        }



    }
}

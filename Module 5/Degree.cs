using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Homework
{
    class Degree
    {

        // array for keeping the courses
        Course[] COURSE = new Course[3];
        Course course;
        

        private int numOfcourse = 0;
        private int maxNumberofCourses = 1;
        private string degreeName;

        //properties
        public string DegName { get { return degreeName; } set { degreeName = value; } }
        
       // constructor
        public Degree(string deg1)
        {
            this.degreeName = deg1;
        }


        // addCourse method
        public void addCourse(Course course)
        {
            this.course = course;
            if (numOfcourse <= maxNumberofCourses)
            {
                COURSE[numOfcourse] = course;
                numOfcourse += 1;

            }
            else
            {
                Console.WriteLine("sorry, you can add maximum 2 courses to one Degree");
                Console.WriteLine("close this console by pressing any key and try again");
                Console.ReadKey();
                Environment.Exit(0);

            }
        }

        
        


    }


}

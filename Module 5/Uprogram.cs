using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Homework
{
    class Uprogram
    {

        // variables
        private Degree degree;
        private string title;
        

        //properties
        public string Title{ get { return title; }set { title = value; }}
        public Degree Degree { get { return degree; } set {degree = value; } }
        
       
        // constructor
        public Uprogram(string title)
        {
            this.title = title;
        }

    // addUprogram method
    public void addUprogram(Degree degree)
    {
        this.degree = degree;
    }

}
}

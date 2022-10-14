using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle_objects
{
    public class Circle
    { // fields properties
        public double Radius { get; set;}
       //constructor
        public Circle(double Radius) 
        {
            this.Radius = Radius;
        }
        //methods, access modifier, (static), return type, (method name), (parameters),
        public string CalculateCir()
        {
            double circ = Radius * 2 * Math.PI;
            return Math.Round(circ,2).ToString();

        }
          public string CalArea()
        {
            double area = Radius * Radius * Math.PI;
            return Math.Round(area,2).ToString();
        }
        
    }
}

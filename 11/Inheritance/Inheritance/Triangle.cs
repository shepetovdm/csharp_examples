using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Triangle : TwoDShape
    {
        string Style;

        public Triangle() 
        {
           Style = "nul";
        }
        
        public Triangle(string s, double w, double h):base(w,h,"треугольник")
        {            
            Style = s;
        }

        public Triangle(double x):base(x,"треугольник")
        {
            Style = "равнобедренный";        
        }

        public Triangle(Triangle ob):base(ob)
        {
            Style = ob.Style;
        }

        public override double Area()
        {
            return Width * Height / 2;
        }

        public void ShowStyle()
        {
            Console.WriteLine("Треугольник " + Style);
        }
    }

    class ColorTriangle : Triangle
    {
        string color;
        public ColorTriangle(string c, string s, double w, double h) : base(s, w, h) 
        {
            color = c;
        }

        public void ShowColor()
        {
            Console.WriteLine(color);
        }
    }

}

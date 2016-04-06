using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class TwoDShape
    {
        double pri_width;
        double pri_height;

        public TwoDShape()
        {
            Width = Height = 0;
            name = "null";            
        }

        public TwoDShape(double w, double h, string n)
        {
            Width = w;
            Height = h;
            name = n;
        }

        public TwoDShape(double x, string n)
        {
            Width = Height = x;
            name = n;
        }

        public TwoDShape(TwoDShape ob)
        {
            Width = ob.Width;
            Height = ob.Height;
            name = ob.name;
        }

        public double Width
        {
            get { return pri_width;  }
            set { pri_width = value < 0 ? -value : value;}
        }

        public double Height
        {
            get { return pri_height; }
            set { pri_height = value < 0 ? -value : value; }
        }

        public string name{get; set;}

        public void ShowDim() 
        {
            Console.WriteLine("Ширина и высота:" + Width + " " + Height);
        }

        public abstract  double Area();           
    }
}


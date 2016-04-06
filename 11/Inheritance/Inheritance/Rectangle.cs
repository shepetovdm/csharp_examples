using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Rectangle : TwoDShape
    {
        public Rectangle(double w, double h): base(w, h,"прямоугольник") {}

        public Rectangle(double x) : base(x, "прямоугольник") { }

        public Rectangle(Rectangle ob) : base(ob) { }

        public bool IsSquare()
        {
            if (Width == Height) return true;
            return false;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}

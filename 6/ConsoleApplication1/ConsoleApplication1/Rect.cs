using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Rect
    {
        public int height;
        public int width;

        public Rect(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int area()
        {
            return this.height * this.width;
        }
    }
}

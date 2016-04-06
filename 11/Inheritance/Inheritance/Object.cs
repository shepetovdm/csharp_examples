using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class MyClass
    {
        static int count = 0;
        int id;

        public MyClass()
        {
           id = count;
           count++;
        }

        public override string ToString()
        {
            return "Объект #" + id + "типа Object";
        }
    }
}

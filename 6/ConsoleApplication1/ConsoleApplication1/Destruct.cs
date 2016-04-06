using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Destruct
    {
        public int x;

        public Destruct(int i) 
        {
            x = i;
        }
        ~Destruct()
        {
            Console.WriteLine("Уничтожить" + x);
        }

        public void Generator(int i) 
        {
            Destruct o = new Destruct(i);
        }
    }
}

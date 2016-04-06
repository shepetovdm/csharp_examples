using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReloadOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeD a = new ThreeD(1, 2, 3);
            ThreeD b = new ThreeD(10, 10, 10);
            ThreeD c = new ThreeD(0,0,0);
            int i;
            
/*  
            if (a) Console.WriteLine("a");            
            if (c) Console.WriteLine("c");

            do
            {
                b.Show();
                b--;
            } while (b);
 */
            i = (int) a;
            Console.WriteLine(i);
            i = (int) a * 2 - (int) b;
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
/*            FailSoftArray fs = new FailSoftArray(5);
            int x;

            Console.WriteLine("Скрытый сбой");
            for (int i = 0; i <= (fs.length * 2); i++)
            {
                fs[i] = i * 10;
                if (fs.ErrFlag)
                    Console.WriteLine("fs["+i+"] вне границ массива");
                x = fs[i];
                Console.Write(x + " ");
            }

            Console.WriteLine(fs[3.6]);
            Console.WriteLine(fs[3.1]);
 */
/*            PwrOfTwo pwr = new PwrOfTwo();
            for (int i = 0; i <= 8; i++) Console.WriteLine(pwr[i]);

            Console.WriteLine(pwr[-1] + " " + pwr[17]);
 */
/*
            FailSoftArray2D fs = new FailSoftArray2D(3, 5);
            Console.WriteLine(fs[3, 3]);
 */
 /*           SimpProp ob = new SimpProp();
            ob.MyProp = 100;
            ob.MyProp = -10;
            Console.WriteLine(ob.MyProp);
  */
  /*          PropAccess ob = new PropAccess();
            ob.IncrProp();
            Console.WriteLine(ob.MyProp);
 */
            RangeArray ra1 = new RangeArray(-5, 5);
            RangeArray ra2 = new RangeArray(1, 10);
            RangeArray ra3 = new RangeArray(-20, -12);

            Console.WriteLine("ra1: " + ra1.length);

            for (int i = -5; i <= 5; i++) ra1[i] = i;
            for (int i = -5; i <= 5; i++) Console.Write(ra1[i] + " ");
            Console.ReadKey();
        }
    }
}

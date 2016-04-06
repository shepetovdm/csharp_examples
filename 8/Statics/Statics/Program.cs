using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  Console.WriteLine(StaticDemo.Val);
            StaticDemo.Val = 8;
            Console.WriteLine(StaticDemo.ValDiv2());
          */
           /*
            CountInst ob;
            for (int i = 0; i < 1000; i++)
            {
                ob = new CountInst();
                Console.WriteLine("Текущий подсчет: " + CountInst.GetCount());
            }
            */
            /*
            Cons ob = new Cons();
            Console.WriteLine("Cons.alpha:" + Cons.alpha);
            Console.WriteLine("ob.beta:" + ob.beta);
            */
            Console.WriteLine(NumericFn.FracPart(5.255));

            Console.ReadKey();
        }
    }
}

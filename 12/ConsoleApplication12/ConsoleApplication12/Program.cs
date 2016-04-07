using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            ByTwos ob = new ByTwos();
            for (int i = 0; i < 5; i++) Console.WriteLine(ob.GetNext());

            ob.Reset();
            Console.WriteLine("Сброс");
            for (int i = 0; i < 5; i++) Console.WriteLine(ob.GetNext());

            ob.SetStart(100);
            Console.WriteLine("Начать с");
            for (int i = 0; i < 5; i++) Console.WriteLine(ob.GetNext());
            
            Console.ReadKey();
        }        
    }
}

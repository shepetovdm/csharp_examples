using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    class Cons
    {
        public static int alpha;
        public int beta;
        
        static Cons()
        {
            alpha = 99;
            Console.WriteLine("в статическом конструкторе");
        }

        public Cons() 
        {
            beta = 100;
            Console.WriteLine("Конструктор экземпляра");
        }

    }
}

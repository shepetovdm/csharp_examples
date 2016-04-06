using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Virtual
    {
    }

    class Base
    {
        public virtual void Who()
        {
            Console.WriteLine("Метод Who в классе Base");
        }
    }

    class Derived1 : Base
    {
        public void Who()
        {
            Console.WriteLine("Метод Who в классе Derived1");
        }
    }

    class Derived2 : Base
    {
        
    }
}

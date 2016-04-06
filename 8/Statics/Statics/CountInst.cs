using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    class CountInst
    {
        static int count = 0;
        public CountInst() 
        {
            count++;
        }

        ~CountInst()
        { 
            count--;
        }

        public static int GetCount() 
        {
            return count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class PwrOfTwo
    {
        public int this[int index] 
        {
            get 
            {
                if ((index >= 0) && (index < 16)) return pwr(index);
                else return -1;
            }
            // Аксессор set отсутсвует        
        }
        int pwr(int p)
        {
            int result = 1;
            for (int i = 0; i < p; i++)
                result *= 2;
            return result;
        }
            
            
    }
}

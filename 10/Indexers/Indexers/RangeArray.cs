using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class RangeArray
    {
        int[] a;
        int lowerBound;
        int upperBound;

        public int length { get; private set;}
        public bool Error { get; private set; }

        public RangeArray(int low, int high)
        {
            high++;
            if (high <= low)
            {
                high = 1;
                low = 0;
            }
            a = new int[high - low];
            length = high - low;
            lowerBound = low;
            upperBound = --high;
        }

        public int this[int index]
        {
            get
            {
                if (ok(index))
                {
                    Error = false;
                    return a[index - lowerBound];
                }
                else
                {
                    Error = true;
                    return 0;
                }
            }
            set 
            {
                if (ok(index))
                {
                    a[index - lowerBound] = value;
                    Error = false;
                }
                else
                {
                    Error = true;
                }
            }
        }

        public bool ok(int index)
        {
            if (index >= lowerBound & index <= upperBound) return true;
            return false;
        }


    }
}

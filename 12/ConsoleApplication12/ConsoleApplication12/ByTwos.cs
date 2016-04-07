using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class ByTwos: ISeries
    {
        int start;
        int val;
        int prev;

        public ByTwos()
        {
            start = 0;
            val = 0;
            prev = -2;
        }

        public int GetNext()
        {
            prev = val;
            val += 2;
            return val;
        }

        public int GetPrevious()
        {
            return prev;
        }

        public void Reset()
        {
            val = start;
            prev = start - 2;
        }

        public void SetStart(int x)
        {
            start = x;
            val = start;
            prev = start - 2;
        }
    }
}

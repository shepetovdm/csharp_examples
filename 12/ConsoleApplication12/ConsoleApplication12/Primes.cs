using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Primes : ISeries    
    {
        int start;
        int val;

        public Primes()
        {
            start = 2;
            val = 2;
        }

        public int GetNext()
        {
            int i, j;
            bool isprime;

            val++;
            for (i = val; i < 1000000; i++)
            {
                isprime = true;
                for (j = 2; j <= i / j; j++)
                { 
                    
                }
            }

        }
    }
}

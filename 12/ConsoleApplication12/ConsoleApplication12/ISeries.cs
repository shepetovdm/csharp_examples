using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    interface ISeries
    {
        int GetNext();
        void Reset();
        void SetStart(int x);
        
    }
}

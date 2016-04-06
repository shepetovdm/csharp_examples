using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class PropAccess
    {
        int prop;

        public PropAccess() { prop = 0; }

        public int MyProp
        { 
            get
            {
                return prop;
            }
            private set 
            {
                prop = value;
            }                       
        }
        public void IncrProp()
        {            
            prop++;
        }

        
    }
}

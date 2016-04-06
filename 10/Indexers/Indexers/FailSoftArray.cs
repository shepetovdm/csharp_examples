using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class FailSoftArray
    {
        int[] a;
                
        public FailSoftArray(int size)
        {
            a = new int[size];
            Length = size;
        }

        public int Length { get; private set; }
        
        public bool Error { get; private set; }
        
        public int this[int index]
        {
            get 
            {
                if (ok(index))
                {
                    Error = false;
                    return a[index];
                }
                else
                {
                    Error = true;
                    return 0;
                }
             }

             set 
             {
                if(ok(index))
                {
                    a[index] = value;
                    Error = false;
                }
                else Error = true;
             }
            }
        public int this[double idx]
        {
            get
            {
                int index;
                if ((idx - (int)idx) < 0.5) index = (int)idx; else index = (int)idx + 1;
                    
                if (ok(index))
                {
                    Error = false;
                    return a[index];
                }
                else
                {
                    Error = true;
                    return 0;
                }
            }

            set
            {
                int index;
                if ((idx - (int)idx) < 0.5) index = (int)idx; else index = (int)idx + 1;
                if (ok(index))
                {
                    a[index] = value;
                    Error = false;
                }
                else Error = true;
            }
        }
        private bool ok(int index) 
          {
            if(index>=0 & index < Length) return true;
              return false;
          }
            
       
    }     
}

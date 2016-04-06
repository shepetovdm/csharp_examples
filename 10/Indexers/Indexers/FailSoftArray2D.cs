
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class FailSoftArray2D
    {
        int[,] a;
        int rows, cols;
        public int length;
        public bool ErrFlag;

        public FailSoftArray2D(int r, int c)
        {
            rows = r;
            cols = c;
            a = new int[rows, cols];
            length = rows * cols;
        }

        public int this[int index1, int index2]
        {
            get
            {
                if (ok(index1, index2))
                {
                    ErrFlag = false;
                    return a[index1, index2];
                }
                else
                {
                    ErrFlag = true;
                    return 0;
                }                
            }

            set 
            {
                if (ok(index1, index2))
                {
                    a[index1, index2] = value;
                    ErrFlag = false;
                }
                else ErrFlag = true;
            }
        }

        private bool ok(int index1, int index2)
        {
            if (index1 >= 0 & index1 < rows & index2 >= 0 & index2 < cols) return true;
            return false;
        }              
    }
}

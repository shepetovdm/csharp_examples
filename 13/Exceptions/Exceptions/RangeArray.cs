using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class RangeArrayException : Exception 
    {
        public RangeArrayException() : base() {}
        public RangeArrayException(string str):base(str) {}
        public RangeArrayException(string str, Exception inner) : base(str, inner) { }
        protected RangeArrayException(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc) : base(si, sc) { }

        public override string ToString()
        {
            return Message;
        }
    }
    
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
                throw new RangeArrayException("Нижний индекс не ниже верхнего");
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
                    throw new RangeArrayException("Ошибка нарушения границ");
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
                    throw new RangeArrayException("Ошибка нарушения границ");
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

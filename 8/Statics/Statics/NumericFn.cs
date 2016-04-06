using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
   static class NumericFn
    {
       static public double Reciprocal(double num)
       {
           return 1 / num;        
       }

       static public double FracPart(double num)
       {
           return num - (int)num;
       }
       
       static public bool IsEven(double num)
       { 
           return (num % 2) == 0 ? true:false;
       }

       static public bool IsOdd(double num)
       {
            return !IsEven(num);
       }
    }
}

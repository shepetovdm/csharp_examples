using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Factorial
    {
        public int FactrI(int n)
        { 
            int res = 1;
            for (int i = 1; i <= n; i++) res *= i;
            return res;
        }
        public int FactrR(int n)
        {            
            if (n == 1) return 1;                      
            return n * FactrR(n - 1);                        
        }
        
        public void DisplayStr(string str)
        {
            if (str.Length > 0)
                DisplayStr(str.Substring(1, str.Length - 1));
            else
                return;
            //Console.WriteLine(str);
            Console.Write(str[0]);
        }
    }
}

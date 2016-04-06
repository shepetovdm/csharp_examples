using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings7
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Программирование - мой конек";
            string string2 = "Программирование - мой конек, который надо использовать, развивать.";
            string string3 = "Другого пути нет";
            int idx;


            Console.WriteLine(string1 + " " + string1.Length);
            Console.WriteLine(string2.ToUpper() + " " + string2.Length);

            for (int i = 0; i < string1.Length; i++) Console.Write(string1[i]);
            idx = string2.IndexOf("мой", StringComparison.Ordinal);
            Console.Write(idx);

            Console.ReadKey();
        }
    }
}

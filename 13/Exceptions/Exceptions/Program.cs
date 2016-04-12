using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[4];

            try
            {
                Console.WriteLine("До генерирования ошибки");

                for (int i = 0; i < 10; i++)
                {
                    nums[i] = i;
                    Console.WriteLine("nums[{0}]:{1}", i, nums[i]);
                }

                Console.WriteLine("Не подлежит выводу");
            }
            catch (IndexOutOfRangeException) 
            {
                Console.WriteLine("Индекс вышел за границы массива");
            }
            Console.WriteLine("После блока перехвата");
            Console.ReadKey();
        }
    }

    class ExcDemo2 
    {
        static void Main(string[] args)
        {
            try
            {
                ExcTest.GenException();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Индекс вышел за границы");
            }
            Console.WriteLine("После блока перехвата исключения");
            Console.ReadKey();
        }
    }
}

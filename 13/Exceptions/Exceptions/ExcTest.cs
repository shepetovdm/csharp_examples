using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class ExcTest
    {
        public static void GenException()
        {
            int[] nums = new int[4];
            Console.WriteLine("До генерирования исключения");
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
                Console.WriteLine("nums[{0}]:{1}", i, nums[i]);
            }
        }
    }
}

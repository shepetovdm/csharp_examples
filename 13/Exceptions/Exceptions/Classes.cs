using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
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

    class Rethrow 
    {
        public static void GenExceptions()
        {
            int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
            int[] denom = { 2, 0, 4, 0 };

            for (int i = 0; i < numer.Length; i++)
            {
                try
                {
                    Console.WriteLine(numer[i] / denom[i]);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Деление на 0 не допустимо");
                }
                catch
                {
                    Console.WriteLine("Индекс вышел за рамки");
                    throw;
                }
            }
        }
    }

    class UseFinally 
    {
        public static void GenExceptions(int what)
        {
            int t;
            int[] nums = new int[2];

            Console.WriteLine("Получить" + what);
            try
            {
                switch (what)
                {
                    case 0:
                        t = 10 / what;
                        break;
                    case 1:
                        nums[4] = 4;
                        break;
                    case 2:
                        return;
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на 0 не допустимо");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Индекс вышел за границы");
            }
            finally
            {
                Console.WriteLine("После выхода из блока try");
            }
        }
    }

    class X 
    {
        int x;
        public X(int a)
        {
            x = a;
        }

        public int Add(X o)
        {
            return x + o.x;
        }
    }

    class ExceptA : Exception 
    {
        public ExceptA(string str) : base(str) { }
        public override string ToString()
        {
            return Message;
        }
    }

    class ExceptB : ExceptA
    {
        public ExceptB(string str) : base(str) { }
        public override string ToString()
        {
            return Message;
        }
    }
}



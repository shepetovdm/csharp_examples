using Indexers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
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
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Индекс вышел за границы");
            }
            Console.WriteLine("После блока перехвата исключения");
            Console.ReadKey();
        }
    }
    class ExcDemo3
    {
        static void Main(string[] args)
        {
            int[] numer = { 4, 8, 16, 32 };
            int[] denom = { 2, 0, 4, 0 };

            for (int i = 0; i < numer.Length;i++)
                try
                {
                    Console.WriteLine(numer[i] / denom[i]);
                }
                catch (DivideByZeroException) 
                {
                    Console.WriteLine("На ноль делить нельзя");
                }
             Console.ReadKey();       
        }

    }

    class ExcDemo4
    {
        static void Main(string[] args)
        {
            int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512};
            int[] denom = { 2, 0, 4, 0 };

            for (int i = 0; i < numer.Length; i++)
                try
                {
                    Console.WriteLine(numer[i] / denom[i]);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("На ноль делить нельзя");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Индекс вышел за рамки");
                }

            Console.ReadKey();       
        }    
    }

    class ExcDemo5
    {
        static void Main(string[] args)
        {
            int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
            int[] denom = { 2, 0, 4, 0 };

            for (int i = 0; i < numer.Length; i++)
                try
                {
                    Console.WriteLine(numer[i] / denom[i]);
                }
                catch
                {
                    Console.WriteLine("Возникла какая-то ошибка");
                }
               
            Console.ReadKey();
        }
    }

    class NestTrys 
    {
        static void Main(string[] args)
        {
            int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
            int[] denom = { 2, 0, 4, 0 };

            try
            {
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
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Индекс вышел за границы");
                Console.WriteLine("Неисправимая ошибка - программа прервана");
            }
            Console.ReadKey();            
        }
    }

    class ThrowDemo 
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("До генерирования исключения");
                throw new DivideByZeroException();
            }
            catch
            {
                Console.WriteLine("Исключение перехвачено");
            }
            Console.WriteLine("После пары операторов try/catch");
            Console.ReadKey();
        }        
    }

    class RethrowDemo 
    {
        static void Main(string[] args)
        {
            try
            {
                Rethrow.GenExceptions();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("НЕисправимая ошибка - программа прервана");                
            }
            Console.ReadKey();
        }
    }

    class FinalyDemo
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                UseFinally.GenExceptions(i);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

    class UseExcept 
    {
        static void Main(string[] args)
        {
            try
            {
                ExcTest.GenException();
            }
            catch (IndexOutOfRangeException exc)
            {
                Console.WriteLine("Стандартное сообщение таково:");
                Console.WriteLine("Свойство StackTrace" + exc.StackTrace);
                Console.WriteLine("Свойство Message" + exc.Message);
                Console.WriteLine("Свойство TargetSite" + exc.TargetSite);                
            }
            Console.WriteLine("После перехвата исключения");
            Console.ReadKey();
        }
    }

    class NREDemo
    {
        static void Main(string[] args)
        {
            X p = new X(10);
            X q = null;
            int val;

            try
            {
                val = p.Add(q);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException");
                Console.WriteLine("Исправление ошибки...\n");

                q = new X(9);
                val = p.Add(q);
            }
            Console.WriteLine("Значение val = {0}", val);
            Console.ReadKey();
        }    
    }

    class RangeArrayDemo
    {
        static void Main(string[] args)
        {
            try
            {
                RangeArray ra = new RangeArray(-5, 5);
                RangeArray ra2 = new RangeArray(1, 10);

                try
                {
                    RangeArray ra3 = new RangeArray(100, -10);
                }
                catch (RangeArrayException exc)
                {
                    Console.WriteLine(exc);
                }
                Console.ReadKey();
            }
            catch(RangeArrayException exc)
            {
                Console.WriteLine(exc);
            }
        }
    }

    class OrderMatters
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 3; x++)
            {
                try
                {
                    if (x == 0) throw new ExceptA("Перехват исключения типа ExceptA");
                    else if (x == 1) throw new ExceptB("Перехват исключения типа ExceptB");
                    else throw new Exception();
                }
                catch (ExceptB exc)
                {
                    Console.WriteLine(exc);
                }
                catch (ExceptA exc)
                {
                    Console.WriteLine(exc);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc);
                }
            }
            Console.ReadKey();
        }
    }
}

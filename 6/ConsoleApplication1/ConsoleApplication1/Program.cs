using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
/*
            // Buildings Example
            Building house = new Building(4,2500,2);
            Building office = new Building(3,4200,3);
            //int areaPP;                                 

            Console.WriteLine("Площадь на одного человека:" + house.AreaPerPerson());                                  
            Console.WriteLine("Площадь на одного человека:" + office.AreaPerPerson());
            Console.WriteLine("Максимальное кол-во чел в здании:" + house.MaxOccupants(12));
            Console.WriteLine("Максимальное кол-во чел в здании:" + office.MaxOccupants(14));
            office.AreaPerPerson();            
 
/*            ChkNum ob = new ChkNum();
            int a, b;
            for (int i = 10; i < 20; i++)
                if (ob.IsPrime(i)) Console.WriteLine(i + "простое число");
                else Console.WriteLine(i + "непростое число");
            a = 12;
            b = 11;
            
            Console.WriteLine(ob.LeastComFactor(a,b));
// Destructor
//*
           int count;

            Destruct ob = new Destruct(0);

            for (count = 1; count < 100; count++) ob.Generator(count);
            Console.WriteLine("Готово!");
*/
            Rect r1 = new Rect(4, 5);
            Rect r2 = new Rect(7, 9);
            Console.WriteLine("Площадь прямоугольника:" + r1.area());
            Console.WriteLine("Площадь прямоугольника:" + r2.area());
            Console.ReadLine();
        }

        
    }
}

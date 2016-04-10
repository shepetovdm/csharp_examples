using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Шилдт", "С#", 2010);
            Book book2 = new Book();
            Book book3;

            Console.WriteLine(book1.Author + book1.Title + book1.Copyright);
            book2.Author = "Солженицын";
            book2.Title = "Август 14-го";
            book2.Title = "1993";
            Console.WriteLine(book2.Author + book2.Title + book2.Copyright);

            book3.Author = "Стивен Кови";
            Console.WriteLine(book3.Author);

            Console.ReadKey();

        }

    }

    class PacketDemo
    {
        static void Main(string[] args)
        {
            Transaction t = new Transaction("31243", -100.12);
            Transaction t2 = new Transaction("AB4655", 345.25);
            Transaction t3 = new Transaction("8475-09", 9800.00);

            t.sendTransaction();
            t2.sendTransaction();
            t3.sendTransaction();
            Console.ReadKey();
        }
    }

    class EnumDemo
    {
        enum Apple { сорт1, сорт2, сорт3, сорт4, сорт5, сорт6 };
        static void Main(string[] args)
        {
            string[] color = 
            {
                "красный",
                "желтый",
                "красный",
                "красный",
                "красный",
                "красновато-зеленый",
            };
            Apple i;
            for (i = Apple.сорт1; i <= Apple.сорт6; i++)
            {
                Console.WriteLine(i + " имеет значение " + (int)i);
            }
            Console.WriteLine();
            for (i = Apple.сорт1; i <= Apple.сорт6; i++)
            {
                Console.WriteLine("Цвет сорта:" + i + color[(int)i]);
            }

            Console.ReadKey();
        }
    }

    class ConveyorDemo
    {
        static void Main(string[] args)
        {
            ConveyorControl c = new ConveyorControl();
            c.Conveyor(ConveyorControl.Action.Старт);
            c.Conveyor(ConveyorControl.Action.Стоп);
        }
    }
}
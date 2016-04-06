using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle();

            t1.Width = 4.0;
            t1.Height = 4.0;
            t1.Style = "Равнобедренный";

            t2.Width = 8.0;
            t2.Height = 12.0;
            t2.Style = "Прямоуголный";

            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine(t1.Area());

            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine(t2.Area());
            */
            Console.ReadKey();
        }
    }

  /*  class B 
    {
        protected int i, j;
        public void Set(int a, int b)
        {
            i = a;
            j = b;
        }

        public void Show()
        {
            Console.WriteLine(i + " " + j);
        }
    }

    class D : B
    {
        int k;
        public void Setk()
        {
            k = i * j;
        }
        public void Showk()
        {
            Console.WriteLine(k);
        }
    }

    class ProtectedDemo 
    {
        static void Main(string[] args)
        {
            D ob = new D();
            ob.Set(2, 3);
            ob.Show();
            ob.Setk();
            ob.Showk();
            Console.ReadKey();
        }
    }

    class Shapes3
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle("равнобедренный", 4.0, 4.0);
            Triangle t2 = new Triangle("равнобедренный", 8.0, 12.0);
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Площадь" + t1.Area());

            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine("Площадь" + t2.Area());
            
            Console.ReadKey();
        }
    }
*/
    //сокрытие имен
    class A
    {
        public int i = 0;

        public void Show()
        { 
            Console.WriteLine("Член i в БАЗОВОМ классе:" + i);
        }
    }

    class B : A 
    {
        new int i;
        public B(int a, int b)
        {
            base.i = a;
            i = b;
        }

        new public void Show()
        {
            base.Show();
            Console.WriteLine("Член i в производном классе:" + i);
        }
    }

    class NameHiding
    {
        static void Main(string[] args)
        {
            B ob = new B(1, 2);
            ob.Show();

            Console.ReadKey();
        }
    }

    class Shapes6
    {
        static void Main(string[] args)
        {
            ColorTriangle t1 = new ColorTriangle("blue", "прямоуголный", 8, 12);
            ColorTriangle t2 = new ColorTriangle("red", "равнобедренный", 2, 2);

            t1.ShowStyle();
            t1.ShowDim();
            t1.ShowColor();
            
            t2.ShowStyle();
            t2.ShowDim();
            t2.ShowColor();
            Console.ReadKey();
        }        
    }

    class Shapes7
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle("прямоуголный", 8, 12);
            Triangle t2 = new Triangle(t1);

            t1.ShowStyle();
            t1.ShowDim();
            
            t2.ShowStyle();
            t2.ShowDim();
            
            Console.ReadKey();
        }
    }

    class OverrideDemo
    {
        static void Main(string[] args)
        {
            Base baseob = new Base();
            Derived1 dob1 = new Derived1();
            Derived2 dob2 = new Derived2();

            Base baseref;
            
            baseref = baseob;
            baseref.Who();

            baseref = dob1;
            baseref.Who();

            baseref = dob2;
            baseref.Who();

            Console.ReadKey();
        }   
    }

    class DynShapes
    {
        static void Main(string[] args)
        {
            TwoDShape[] shapes = new TwoDShape[5];
            shapes[0] = new Triangle("прямоуголный", 8, 12);
            shapes[1] = new Rectangle(10);
            shapes[2] = new Rectangle(10,4);
            shapes[3] = new Triangle(7);
            //shapes[4] = new TwoDShape(10, 20, "общая форма");

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine("Объект -" + shapes[i].name);
                Console.WriteLine("Площадь -" + shapes[i].Area());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }

    class AbsShape 
    {
        static void Main(string[] args)
        {
            TwoDShape[] shapes = new TwoDShape[4];
            shapes[0] = new Triangle("прямоуголный", 8, 12);
            shapes[1] = new Rectangle(10);
            shapes[2] = new Rectangle(10, 4);
            shapes[3] = new Triangle(7);

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine("Объект -" + shapes[i].name);
                Console.WriteLine("Площадь -" + shapes[i].Area());
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }

    class Test 
    {
        static void Main(string[] args)
        {
            MyClass ob1 = new MyClass();
            MyClass ob2 = new MyClass();
            MyClass ob3 = new MyClass();

            Console.WriteLine(ob1);
            Console.WriteLine(ob2);
            Console.WriteLine(ob3);

            Console.ReadKey();
        }     
    }

    class GenericDemo
    {
        static void Main(string[] args)
        {
            object[] ga = new object[10];
            for (int i = 0; i < 3; i++) ga[i] = i;
            for (int i = 3; i < 6; i++) ga[i] = i+0.01;
            ga[6] = "конец";

            for (int i = 0; i < ga.Length; i++) Console.WriteLine(ga[i]);
            Console.ReadKey();
        }
    }
}

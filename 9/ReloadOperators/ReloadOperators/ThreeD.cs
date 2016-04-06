using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReloadOperators
{
    class ThreeD
    {
        int x, y, z;
        public ThreeD() { x = y = z = 0; }
        public ThreeD(int i, int j, int k) { x = i; y = j; z = k; }

        public static ThreeD operator + (ThreeD op1, ThreeD op2)
        { 
            ThreeD result = new ThreeD();
            result.x = op1.x + op2.x;
            result.y = op1.y + op2.y;
            result.z = op1.z + op2.z;
            return result;
        }

        public static ThreeD operator +(ThreeD op1, int op2)
        {
            ThreeD result = new ThreeD();
            result.x = op1.x + op2;
            result.y = op1.y + op2;
            result.z = op1.z + op2;
            return result;
        }

        public static ThreeD operator +(int op1, ThreeD op2)
        {
            ThreeD result = new ThreeD();
            result.x = op1 + op2.x;
            result.y = op1 + op2.y;
            result.z = op1 + op2.z;
            return result;
        }

        public static ThreeD operator - (ThreeD op1, ThreeD op2)
        {
            ThreeD result = new ThreeD();
            result.x = op1.x - op2.x;
            result.y = op1.y - op2.y;
            result.z = op1.z - op2.z;
            return result;
        }

        //Унарный оператор "-"
        public static ThreeD operator - (ThreeD op)
        {
            ThreeD result = new ThreeD();
            result.x = -op.x;
            result.y = -op.y;
            result.z = -op.z;
            return result;
        }

        //Унарный оператор "++" "--"
        public static ThreeD operator ++(ThreeD op)
        {
            ThreeD result = new ThreeD();
            result.x = op.x + 1;
            result.y = op.y + 1;
            result.z = op.z + 1;
            
            return result;
        }

        public static ThreeD operator --(ThreeD op)
        {
            ThreeD result = new ThreeD();
            result.x = op.x - 1;
            result.y = op.y - 1;
            result.z = op.z - 1;

            return result;
        }

        //Операторы отношения

        public static bool  operator < (ThreeD op1, ThreeD op2)
        {
            if(Math.Sqrt(op1.x * op1.x + op1.y * op1.y + op1.z*op1.z) <
              Math.Sqrt(op1.x * op2.x + op2.y * op2.y + op2.z*op2.z))
                return true;
            else
                return false;
        }

        public static bool operator > (ThreeD op1, ThreeD op2)
        {
            if (Math.Sqrt(op1.x * op1.x + op1.y * op1.y + op1.z * op1.z) >  
              Math.Sqrt(op2.x * op2.x + op2.y * op2.y + op2.z * op2.z))
                return true;
            else
                return false;
        }

        //Операторы True False
        public static bool operator true(ThreeD op)
        {
            if ((op.x != 0) || (op.y != 0) || (op.z != 0))
                return true;
            else
                return false;
        }

        public static bool operator false(ThreeD op)
        {
            if ((op.x == 0) && (op.y == 0) && (op.z == 0))
                return true;
            else
                return false;
        }

        //Логические операторы "|", "&"
         public static bool operator | (ThreeD op1, ThreeD op2)
        {
             if( ((op1.x != 0) || (op1.y != 0) || (op1.z != 0)) |
                ((op2.x != 0) || (op2.y != 0) || (op2.z != 0)) )
                return true;
             else
                return false;
        }

         public static bool operator &(ThreeD op1, ThreeD op2)
         {
             if (((op1.x != 0) && (op1.y != 0) && (op1.z != 0)) &
                ((op2.x != 0) && (op2.y != 0) && (op2.z != 0)))
                 return true;
             else
                 return false;
         }

         public static bool operator !(ThreeD op)
         {
             if ((op.x != 0) || (op.y != 0) || (op.z != 0))                 
                 return false;
             else
                 return true;
         }

   /*      public static implicit operator int(ThreeD op1)
         {
             return op1.x * op1.y * op1.z;
         }*/

         public static explicit operator int(ThreeD op1)
         {
             return op1.x * op1.y * op1.z;
         }


        public void Show()
        {
            Console.WriteLine(x + ", " + y + ", " + z);
        }
    }
}

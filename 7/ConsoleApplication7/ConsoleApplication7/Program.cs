using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //Двумерные массивы 
            int[,] table = new int[3,4];
            int i, j;
            Random r = new Random();
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    table[i, j] = r.Next(100);
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }
            */ 
            /*//Ступенчатые массивы
            int[][] stage = new int[3][];            
            stage[0] = new int[22];
            stage[1] = new int[6];
            stage[2] = new int[8];
            int i, j;

            for (i = 0; i < stage.Length; i++)
            {
                for (j = 0; j < stage[i].Length;j++)
                {
                    Console.Write(stage[i][j]);
                }
                Console.WriteLine(); 
            }
            */
            /*
            int[] m1 = new int[6];
            int[] m2 = new int[6];
            int sum = 0;
            
            for(int i = 0; i<m1.Length;i++) 
            {                
                m1[i] = i;
                m2[i] = -i;
            }
            
            //for(int i = 0; i<m2.Length;i++) Console.Write(m2[i] + " ");
            foreach (int x in m1)
            {                
                sum += x;                
            }
            //Console.Write("Сумма:"+ sum);
            */

            int[] nums = new int[10];
            int val;
            Boolean found = false;

            for (int i = 0; i < nums.Length; i++) nums[i] = i;
            val = 5;
            foreach (int x in nums)
            {
                if (x == val)
                {
                    found = true;
                    break;
                }
            }
            if (found) Console.Write("Значение найдено");
            Console.ReadKey();
        }
    }
}

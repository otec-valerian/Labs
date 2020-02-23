using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main()
        {
            int[] decrNumb = new []{-92, 16, 62};
            int[,] checkNumb = new int[,] {{32, 45}, {-233, 231}, {143, 129}};
            foreach (var x in decrNumb)
            {
                DecrementByOne(x, out int r);
                Console.WriteLine($"Decrement {x} by 1 is: {r}");
                Console.WriteLine();
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Comparing {checkNumb[i,0]} and {checkNumb[i,1]}: {LessCheckReturn(checkNumb[i,0], checkNumb[i,1])}");
                LessCheckParametr(checkNumb[i,0], checkNumb[i,1], out bool res);
                Console.WriteLine($"Comparing {checkNumb[i,0]} and {checkNumb[i,1]}: {res}");
                Console.WriteLine();
            }
        }
        

        private static void DecrementByOne(int num, out int result)
        {
            int x = 0;
            while ((num & (1 << x)) == 0)
            {
                num = num ^ (1 << x);
                x++;
            }
            num = num ^ (1 << x);
            result = num;
        }


        private static int Sum(int num1, int num2)
        {
            while (num2 != 0)
            {
                int cur = num1 & num2;
                num1 = num1 ^ num2;
                num2 = cur << 1;
            }

            return num1;
        }
        
        
        private static bool LessCheckReturn(int num1, int num2)
        {
            num2 = Sum(~num2, 1);
            if (Sum(num1, num2) > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        
        
        private static void LessCheckParametr(int num1, int num2, out bool result)
        {
            num2 = Sum(~num2, 1);
            if (Sum(num1, num2) > 0)
            {
                result = false;
            }
            else
            {
                result = true;
            }
        }
    }
}
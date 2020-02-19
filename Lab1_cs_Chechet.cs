using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main()
        {
            int[] decrNumb = new []{-92, 16, 62};
            int[,] checkNumb = new int[,] {{-2134, -2143}, {38, 40}, {143, 129}};
            foreach (var x in decrNumb)
            {
                DecrementByOne(x, out int r);
                Console.WriteLine($"Decrement {x} by 1 is: {r}");
                Console.WriteLine();
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Comparing {checkNumb[i,0]} and {checkNumb[i,1]}: {LessCheckReturn(checkNumb[i,0], checkNumb[i,1])}");
                LessCheckParametr(checkNumb[i,0], checkNumb[i,1], out string str);
                Console.WriteLine($"Comparing {checkNumb[i,0]} and {checkNumb[i,1]}: {str}");
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


        private static string LessCheckReturn(int num1, int num2)
        {
            int l = Convert.ToString(Math.Abs(Math.Max(num1, num2)),2).Length - 1;
            for (int j = l; j >= 0; j--)
            {
                if ((num1 & (num1 << j)) < (num2 & (num2 << j)))
                {
                    return $"Yes, {num1} is lesser";
                }
            }

            return $"No, {num1} isn't bigger";
        }
        
        
        
        private static void LessCheckParametr(int num1, int num2, out string result)
        {
            int l = Convert.ToString(Math.Abs(Math.Max(num1, num2)),2).Length - 1;
            for (int j = l; j >= 0; j--)
            {
                if ((num1 & (num1 << j)) < (num2 & (num2 << j)))
                {
                    result = $"Yes, {num1} is lesser";
                    return;
                }
            }

            result = $"No, {num1} isn't bigger";
        }
    }
}
   
    



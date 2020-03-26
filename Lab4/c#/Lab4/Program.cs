using System;
using System.Threading.Channels;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Trapeze TR1 = new Trapeze();
            int[] a = new [] {1, 2};
            int[] b = new [] {5, 9};
            int[] c = new [] {4, 56};
            int[] d = new [] {88, 16};
            Trapeze TR2 = new Trapeze(a, b, c, d);
            Trapeze TR3 = new Trapeze("sameside");
            Console.WriteLine("TR1 coordinates: ");
            TR1.PrintCoord();
            Console.WriteLine("TR2 coordinates: ");
            TR2.PrintCoord();
            Console.WriteLine("TR3 coordinates: ");
            TR3.PrintCoord();
            TR1 = TR1 - 3;
            Console.WriteLine("TR1 coordinates after decrementing by 3: ");
            TR1.PrintCoord();
            double res = TR2 * TR3;
            Console.WriteLine("Multiplying's TR2 and TR3 result: ");
            Console.WriteLine(res);
            Console.WriteLine("Rewriting the result to the TR1: ");
            TR1 = res;
            TR1.PrintCoord();
            

        }
    }
}
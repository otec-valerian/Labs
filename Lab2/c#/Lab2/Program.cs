using System;
using System.Net.Mime;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        { 
            Text Text1 = new Text("qwery", "ewrw e", "21441");
            Text1.PrintText();
            Text1.AddLine( "BABBAH");
            Text1.PrintText();
            Text1.DelLine(2);
            Text1.PrintText();
            Text1.DelText();
            Text1.PrintText();
            Text1 = new Text("1","22","333",",..,.+_)");
            MyString a = Text1.FindBiggestString();
            Console.WriteLine(a.Text);
            int b = Text1.NumberOfSymb();
            Console.WriteLine(b);
            double c = Text1.PercentOfSymb();
            Console.WriteLine(c);
        }

        
    }
}
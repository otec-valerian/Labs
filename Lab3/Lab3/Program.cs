using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Tusk test = new Tusk("qwerery", "fddwgew");
            MyString first_line = test[1];
            Console.WriteLine(first_line.Text);
            MyString second_line = test[2];
            Console.WriteLine(second_line.Text);
            int content = test.Number;
            Console.WriteLine(content);
            test[1] = new MyString("99999");
            Console.WriteLine(test[1].Text);

        }
    }
}
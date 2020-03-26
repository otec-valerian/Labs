using System;
using System.Runtime.CompilerServices;

namespace Lab3
{
    public class Tusk
    {
        private MyString[] content { get; set; }

        private int number;

        public int Number
        {
            get
            {
                Console.WriteLine("Enter the password: ");
                int pass = Convert.ToInt32(Console.ReadLine());
                if (pass == 1986)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Invalid Password");
                    return 0;
                }
            }
            set
            {
                Console.WriteLine("Enter the password: ");
                int pass = Convert.ToInt32(Console.ReadLine());
                if (pass == 1986 && value.GetType() == typeof(MyString[]))
                {
                    this.number = value;
                }
                else
                {
                    Console.WriteLine("Invalid Password or type");
                }
            }
             
            
        }

        public Tusk(params string[] args)
        {
            this.content = new MyString[args.Length];
            int counter = 0;
            foreach (var str in args)
            {
                this.content[counter] = new MyString(str);
                counter++;
            }

            this.number = this.content.Length;
        }


        public MyString this[int i]
        {
            get
            {
                try
                {
                    return this.content[i-1];
                }
                catch (IndexOutOfRangeException ex)
                {
                    throw;
                }
                
            }
            set { this.content[i - 1] = value; }

        }
        
        
        
    }
}
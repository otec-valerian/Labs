using System;
using System.Net.Mime;
using System.Resources;

namespace Lab2
{
    public class Text
    {
        private MyString[] textLines;

        public Text(params string[] args)
        {
            textLines = new MyString[args.Length];
            int counter = 0;
            foreach (var str in args)
            {
                textLines[counter] = new MyString(str);
                counter++;
            }
        }
        
        public void PrintText()
        {
            foreach (MyString obj in textLines)
            {
                Console.WriteLine(obj.Text);
            }
            
        }

        public void AddLine(params string[] args)
        {
            MyString[] exTextlines = new MyString[this.textLines.Length + args.Length];
            int count = 0;
            foreach (var obj in this.textLines)
            {
                exTextlines[count] = obj;
                count++;
            }

            foreach (var obj in args)
            {
                exTextlines[count] = new MyString(obj);
                count++;
            }

            this.textLines = exTextlines;
        }

        public void DelLine(int num)
        {
            MyString[] exTextlines = new MyString[this.textLines.Length - 1];
            int count = 0;
            for (int i = 0; i < num; i++)
            {
                exTextlines[i] = this.textLines[i];
            }
            
            for (int i = num + 1; i < this.textLines.Length; i++)
            {
                exTextlines[i - 1] = this.textLines[i];
            }
            this.textLines = exTextlines;
        }

        public void DelText()
        {
            this.textLines = new MyString[] {};
        }


        public MyString FindBiggestString()
        {
            int big_v = 0;
            MyString big_str = this.textLines[0];
            for (int i = 0; i < this.textLines.Length; i++)
            {
                if (this.textLines[i].Text.Length > big_v)
                {
                    big_v = this.textLines[i].Text.Length;
                    big_str = this.textLines[i];
                }
            }

            return big_str;
        }

        public int NumberOfSymb()
        {
            int sum = 0;
            for (int i = 0; i < this.textLines.Length; i++)
            {
                sum += this.textLines[i].Text.Length;
            }

            return sum;
        }

        public double PercentOfSymb()
        {
            float total = this.NumberOfSymb();
            float cur = 0;
            for (int i = 0; i < this.textLines.Length; i++)
            {
                for (int j = 0; j < this.textLines[i].Text.Length; j++)
                {
                    if (Char.IsLetterOrDigit(this.textLines[i].Text[j]))
                    {
                        cur++;
                    } 
                }
            }

            float r = cur / total;
            return Math.Round(r * 100, 2);
        }
    }
}
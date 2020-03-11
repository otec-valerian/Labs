using System;
using System.Collections.Generic;
using System.Net.Mime;

namespace Lab2
{
    public class MyString
    {
        private char[] text;

        public MyString(string txt)
        {
            text = txt.ToCharArray();
        }

        public char[] Text => text;
    }
    
}
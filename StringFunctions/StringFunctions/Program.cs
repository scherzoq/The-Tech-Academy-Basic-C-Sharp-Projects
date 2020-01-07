using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            string quote = "The man said, \"Hello, John.\"\nHello on a new line.\n\tHello on a tab.";
            // string fileName = "C:\\Users\\John";
            string fileName = @"C:\Users\John";

            // bool trueOrFalse = name.Contains("h");
            bool trueOrFalse = name.EndsWith("h");

            int length = name.Length;

            name = name.ToUpper();

            Console.WriteLine(quote);
            Console.WriteLine(fileName);
            Console.WriteLine(trueOrFalse);
            Console.WriteLine(length);
            Console.WriteLine(name);
            
            // create instance of class StringBuilder:
            StringBuilder sb = new StringBuilder();
            sb.Append("My name is John");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 5 + 10;
            int otherTotal = 12 + 22;
            int combined = total + otherTotal;
            Console.WriteLine("Five plus ten = " + total.ToString());
            Console.WriteLine(combined);
            Console.ReadLine();

            int difference = 10 - 5;
            Console.WriteLine("Ten minus five = " + difference.ToString());
            Console.ReadLine();

            int product = 10 * 5;
            Console.WriteLine(product);
            Console.ReadLine();

            int quotient1 = 100 / 5;
            double quotient2 = 100.0 / 17.0;
            Console.WriteLine(quotient1);
            Console.WriteLine(quotient2);
            Console.ReadLine();

            int remainder = 11 % 2;
            Console.WriteLine(remainder);
            Console.ReadLine();

            bool trueOrFalse = 12 < 5;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

            int roomTemperature = 70;
            int currentTemperature = 70;
            bool isWarm = currentTemperature >= roomTemperature;
            Console.Write(isWarm);
            Console.ReadLine();
        }
    }
}

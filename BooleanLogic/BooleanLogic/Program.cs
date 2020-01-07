﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && false);

            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || false);

            Console.WriteLine(true == true);
            Console.WriteLine(true == false);
            Console.WriteLine(false == false);

            Console.WriteLine(true != true);
            Console.WriteLine(true != false);
            Console.WriteLine(false != false);

            Console.WriteLine(true ^ true);
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ false);

            Console.WriteLine(true && true && true && false);
            Console.WriteLine(true && true && true || false);

            if (true && ((true || false) || true) && ((false && false) || (true && true)))
            {
                Console.WriteLine("Wow that was confusing.");
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsExercise_p164
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiation
            MathOperation test = new MathOperation();

            Console.WriteLine("Please enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            test.DivideByTwo(num, out int prod1, out int rem1);
            Console.WriteLine(num + " divided by 2 equals " + prod1 + " with remainder of " + rem1);
            Console.ReadLine();

            // static class
            MoreMathOp.DivideByThree(20, out int prod2, out int rem2);
            Console.WriteLine("20 divided by 3 equals " + prod2 + " with remainder of " + rem2);
            Console.ReadLine();
        }
    }
}

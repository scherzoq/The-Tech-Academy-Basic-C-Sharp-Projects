using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsExercise_p156
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer:");
            int number = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(number + " multiplied by 3 equals " + MathOperations.MultiplyByThree(number));
            Console.WriteLine(number + " minus 50 equals " + MathOperations.SubtractFifty(number));
            Console.WriteLine(number + " plus 10000 equals " + MathOperations.AddTenThousand(number));

            Console.ReadLine();
        }
    }
}

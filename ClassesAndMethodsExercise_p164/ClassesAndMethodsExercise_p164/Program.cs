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
            MathOperation.DivideByTwo(5, out int rem1);
            Console.WriteLine("The remainder is " + rem1);
            Console.ReadLine();

            MathOperation.DivideByTwo(20, out int rem2);
            Console.WriteLine("The remainder is " + rem2);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsExercise_p159
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = MathOperations.mathOp(50);
            Console.WriteLine(numberOne);

            double numberTwo = MathOperations.mathOp(25.43);
            Console.WriteLine(numberTwo);

            int numberThree = MathOperations.mathOp("9");
            Console.WriteLine(numberThree);

            Console.ReadLine();
        }
    }
}

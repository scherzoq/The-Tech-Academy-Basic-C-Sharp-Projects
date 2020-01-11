
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsExercise_p160
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first number:");
            int numOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number (optional)");
            try
            {
                int numTwo = Convert.ToInt32(Console.ReadLine());
                int answer = MathOperation.mathOp(numOne, numTwo);
                Console.WriteLine(numOne + " times 3 plus " + numTwo + " times 5 equals " + answer);
            }
            catch (FormatException)
            {
                Console.WriteLine("No number entered; default of 2 used");
                int answer = MathOperation.mathOp(numOne);
                Console.WriteLine(numOne + " times 3 plus 2 times 5 equals " + answer);
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}

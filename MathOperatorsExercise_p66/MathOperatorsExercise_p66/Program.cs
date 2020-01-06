using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperatorsExercise_p66
{
    class Program
    {
        static void Main(string[] args)
        {
            // part 1
            Console.WriteLine("Enter a number (integer only for now, please!):");
            string userNum1 = Console.ReadLine();
            int product = (50 * Convert.ToInt32(userNum1));
            Console.WriteLine("Your number multiplied by 50 = " + product.ToString() + "\n");
            
            // part 2
            Console.WriteLine("Enter another number (another integer!):");
            string userNum2 = Console.ReadLine();
            int sum = (25 + Convert.ToInt32(userNum2));
            Console.WriteLine("Your number plus 25 = " + sum.ToString() + "\n");
            
            // part 3
            Console.WriteLine("Enter another number (decimal numbers are OK going forward!):");
            string userNum3 = Console.ReadLine();
            double quotient = (Convert.ToDouble(userNum3) / 12.5);
            Console.WriteLine("Your number divided by 12.5 = " + quotient.ToString() + "\n");
           
            // part 4
            Console.WriteLine("Enter yet another number:");
            string userNum4 = Console.ReadLine();
            bool greaterThanFifty = Convert.ToDouble(userNum4) > 50;
            Console.WriteLine("Is your number greater than 50? " + greaterThanFifty.ToString() + "\n");

            // part 5
            Console.WriteLine("Enter one last number:");
            string userNum5 = Console.ReadLine();
            double remainder = Convert.ToDouble(userNum5) % 7;
            Console.WriteLine("The remainder when your number is divided by 7 is " + remainder.ToString());
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise_p147
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dividends = new List<int> { 12, 20, 23, 145, 238, 429, 821, 1208, 5252, 15243, 82411 };

            try
            {
                Console.WriteLine("Please enter a number to divide by:");
                int divisor = Convert.ToInt32(Console.ReadLine());
                foreach (int dividend in dividends)
                {
                    int quotient = dividend / divisor;
                    int remainder = dividend % divisor;
                    Console.WriteLine(dividend + " divided by " + divisor + " equals " + quotient + " with a remainder of " + remainder);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please don't divide by zero!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\"Finally\" out of try-catch block! Program execution finished");
                Console.ReadLine();
            }
        }
    }
}

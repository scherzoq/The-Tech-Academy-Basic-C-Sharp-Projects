using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick another number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divded by " + numberTwo + " equals " + numberThree);            
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

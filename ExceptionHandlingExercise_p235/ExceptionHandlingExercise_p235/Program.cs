using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise_p235
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How old are you?");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0) throw new AgeException();
                int year1 = Convert.ToInt32(DateTime.Now.Year) - age;
                int year2 = year1 - 1;
                Console.WriteLine("You were born in {0} or {1}", year2, year1);
            }
            catch (AgeException)
            {
                Console.WriteLine("Please enter a valid age.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Please contact your System Administrator.");                
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}

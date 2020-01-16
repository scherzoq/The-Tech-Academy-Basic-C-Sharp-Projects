using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExercise_p192
{
    class Program
    {
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the current day of the week?");
            try
            {
                string currentDay = Console.ReadLine();
                DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), currentDay);
                Console.WriteLine("Have a nice " + day + "!");
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

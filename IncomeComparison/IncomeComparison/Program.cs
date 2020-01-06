using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate?");
            string rate1 = Console.ReadLine();
            double hourlyRate1 = Convert.ToDouble(rate1);
            Console.WriteLine("Hours worked per week?");
            string hours1 = Console.ReadLine();
            double hoursPerWeek1 = Convert.ToDouble(hours1);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            string rate2 = Console.ReadLine();
            double hourlyRate2 = Convert.ToDouble(rate2);
            Console.WriteLine("Hours worked per week?");
            string hours2 = Console.ReadLine();
            double hoursPerWeek2 = Convert.ToDouble(hours2);

            double weeklySalary1 = hourlyRate1 * hoursPerWeek1;
            double weeklySalary2 = hourlyRate2 * hoursPerWeek2;
            bool person1Greater = weeklySalary1 > weeklySalary2;
            Console.WriteLine("Weekly salary of Person 1:");
            Console.WriteLine(weeklySalary1);
            Console.WriteLine("Weekly salary of Person 2:");
            Console.WriteLine(weeklySalary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(person1Greater);
            Console.ReadLine();
        }
    }
}

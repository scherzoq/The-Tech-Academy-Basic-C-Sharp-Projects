using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int driverAge = Convert.ToInt32(age);
            
            Console.WriteLine("Have you ever had a DUI (enter \"true\" for yes or \"false\" for no)");
            string dui = Console.ReadLine();
            bool driverDui = Convert.ToBoolean(dui);
            
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int driverTickets = Convert.ToInt32(tickets);

            bool driverQualified = (driverAge > 15 && driverDui == false && driverTickets <= 3);
            Console.WriteLine("Qualified for auto insurance?");
            Console.WriteLine(driverQualified);
            Console.ReadLine();
        }
    }
}

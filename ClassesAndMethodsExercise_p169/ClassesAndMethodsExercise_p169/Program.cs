using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsExercise_p169
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee test = new Employee() { FirstName = "Sample", LastName = "Student" };
            test.SayName();
            Console.ReadLine();
        }
    }
}

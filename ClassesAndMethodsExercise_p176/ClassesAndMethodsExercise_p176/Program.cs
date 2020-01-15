using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsExercise_p176
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee test = new Employee { firstName = "Sample", lastName = "Student" };
            test.SayName();
            Console.ReadLine();

            IQuittable interfaceTest = test;
            interfaceTest.Quit(test);
            Console.ReadLine();
        }
    }
}

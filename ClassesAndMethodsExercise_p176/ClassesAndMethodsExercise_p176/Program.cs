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
            Employee<string> testOne = new Employee<string> { firstName = "Sample", lastName = "Student" };
            testOne.things = new List<string>();
            testOne.things.Add("desk");
            testOne.things.Add("laptop");
            testOne.things.Add("phone");
            testOne.things.Add("chair");
            testOne.things.Add("pen");
            testOne.things.Add("paper");

            Employee<int> testTwo = new Employee<int> { firstName = "Another", lastName = "Student" };
            testTwo.things = new List<int>();
            testTwo.things.Add(30);
            testTwo.things.Add(55);
            testTwo.things.Add(93);

            foreach (string thing in testOne.things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();

            foreach (int thing in testTwo.things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();

            //test.SayName();
            //Console.ReadLine();

            //IQuittable interfaceTest = test;
            //interfaceTest.Quit(test);
            //Console.ReadLine();
        }
    }
}

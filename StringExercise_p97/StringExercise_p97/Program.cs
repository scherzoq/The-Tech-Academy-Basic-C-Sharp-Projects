using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExercise_p97
{
    class Program
    {
        static void Main(string[] args)
        {
            // concatenate strings and use "ToUpper" method
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            name = name.ToUpper();
            Console.WriteLine("Where do you live (enter name of either city or state)?");
            string place = Console.ReadLine();
            Console.WriteLine("Enter an adjective to describe this place:");
            string adjective = Console.ReadLine();
            string greeting = "Hello, " + name + " of " + adjective + " " + place + "!";
            Console.WriteLine(greeting);
            Console.WriteLine("(press enter to continue)");
            Console.ReadLine();

            // StringBuilder
            StringBuilder mobyDick = new StringBuilder();
            mobyDick.Append("Call me Ishmael. ");
            mobyDick.Append("Some years ago - never mind how long precisely - having little or no money in my purse, and nothing particular to interest me on shore, I thought I would sail about a little and see the watery part of the world. ");
            mobyDick.Append("It is a way I have of driving off the spleen and regulating the circulation.");
            Console.WriteLine(mobyDick);
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOExercise_p218
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string number = Console.ReadLine();
            File.WriteAllText(@"C:\Users\John\Logs\number.txt", number);
            string text = File.ReadAllText(@"C:\Users\John\Logs\number.txt");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}

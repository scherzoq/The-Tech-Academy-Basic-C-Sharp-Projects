using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExercise_p197
{
    class Program
    {
        static void Main(string[] args)
        {
            Number sample = new Number();
            sample.Amount = 3.14159M;
            Console.WriteLine(sample.Amount);
            Console.ReadLine();
        }
    }
}

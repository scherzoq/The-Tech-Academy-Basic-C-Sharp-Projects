using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsExercise_p164
{
    public class MathOperation
    {
        public static void DivideByTwo(int number, out int remainder)
        {
            Console.WriteLine(number + " divided by two equals " + number / 2);
            remainder = number % 2;
        }

        public static void DivideByTwo(string number, out int remainder)
        {
            int num = Convert.ToInt32(number);
            Console.WriteLine(num + " divided by two equals " + num / 2);
            remainder = num % 2;
        }
    }
}

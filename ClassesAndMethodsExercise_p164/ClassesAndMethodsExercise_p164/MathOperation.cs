using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsExercise_p164
{
    public class MathOperation
    {
        public void DivideByTwo(int number, out int product, out int remainder)
        {
            product = number / 2;
            remainder = number % 2;
        }

        public void DivideByTwo(string number, out int product, out int remainder)
        {
            int num = Convert.ToInt32(number);
            product = num / 2;
            remainder = num % 2;
        }
    }
}

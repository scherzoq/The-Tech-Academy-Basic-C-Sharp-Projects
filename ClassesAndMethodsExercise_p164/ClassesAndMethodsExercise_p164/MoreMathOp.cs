using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsExercise_p164
{
    public static class MoreMathOp
    {
        public static void DivideByThree(int number, out int product, out int remainder)
        {
            product = number / 3;
            remainder = number % 3;
        }

    }
}

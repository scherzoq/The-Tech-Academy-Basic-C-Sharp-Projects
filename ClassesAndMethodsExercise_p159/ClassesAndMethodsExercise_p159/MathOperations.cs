using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsExercise_p159
{
    public class MathOperations
    {
        private static int num;

        public static int mathOp(int number)
        {
            return number * 2;
        }

        public static double mathOp(double number)
        {
            return number / 2;
        }

        public static int mathOp(string number)
        {
            num = Convert.ToInt32(number);
            return num + 25000;
        }
    }
}

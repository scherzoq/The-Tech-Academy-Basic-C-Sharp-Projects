using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsExercise_p176
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Employee Name:");
            base.SayName();
        }

        public void Quit(Employee employee)
        {
            Console.WriteLine(employee.firstName + " " + employee.lastName + " has quit");
        }
    }
}

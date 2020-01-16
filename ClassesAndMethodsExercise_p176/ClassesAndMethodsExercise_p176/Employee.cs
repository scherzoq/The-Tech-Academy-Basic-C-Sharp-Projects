using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsExercise_p176
{
    class Employee<T> : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Employee Name:");
            Console.WriteLine(firstName + " " + lastName);
        }

        //public void Quit(Employee employee)
        //{
        //    Console.WriteLine(employee.firstName + " " + employee.lastName + " has quit");
        //}

        // Generics exercise, page 187
        public List<T> things { get; set; }
    }
}

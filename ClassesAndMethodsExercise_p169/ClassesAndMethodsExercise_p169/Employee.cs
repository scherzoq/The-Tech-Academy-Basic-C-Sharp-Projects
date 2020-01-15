using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsExercise_p169
{
    public class Employee : Person
    {
        public int Id { get; set; }

        // operator overloading added for p. 184 assignment
        public static bool operator == (Employee firstEmployee, Employee secondEmployee)
        {
            return firstEmployee.Id == secondEmployee.Id;
        }

        public static bool operator != (Employee firstEmployee, Employee secondEmployee)
        {
            return firstEmployee.Id != secondEmployee.Id;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsExercise_p169
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee test = new Employee() { FirstName = "Sample", LastName = "Student" };
            //test.SayName();
            //Console.ReadLine();

            // lambda functions for p. 202 assignment
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { FirstName = "George", LastName = "Washington", Id = 1 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Adams", Id = 2 });
            employees.Add(new Employee() { FirstName = "Tommy", LastName = "Jefferson", Id = 3 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Madison", Id = 4 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Monroe", Id = 5 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Quincy", Id = 6 });
            employees.Add(new Employee() { FirstName = "Andy", LastName = "Jackson", Id = 7 });
            employees.Add(new Employee() { FirstName = "Marty", LastName = "Van Buren", Id = 8 });
            employees.Add(new Employee() { FirstName = "Bill", LastName = "Harrison", Id = 9 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Tyler", Id = 10 });

            List<Employee> employeesJoe = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    employeesJoe.Add(employee);
                }
            }

            List<Employee> employeesJoeLamb = employees.Where(x => x.FirstName == "Joe").ToList();

            List<Employee> employeesGreaterThanFive = employees.Where(x => x.Id > 5).ToList();

            foreach (Employee employee in employeesJoe)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + ", Id: " + employee.Id);
            }

            Console.ReadLine();

            foreach (Employee employee in employeesJoeLamb)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + ", Id: " + employee.Id);
            }

            Console.ReadLine();

            foreach (Employee employee in employeesGreaterThanFive)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + ", Id: " + employee.Id);
            }

            Console.ReadLine();
        }
    }
}

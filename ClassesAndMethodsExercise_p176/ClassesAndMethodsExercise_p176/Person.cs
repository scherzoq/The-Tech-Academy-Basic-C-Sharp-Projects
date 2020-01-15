using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsExercise_p176
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public virtual void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}

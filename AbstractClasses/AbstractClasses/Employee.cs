using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Employee : Person, IQuittable
    {
        public override void sayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        public void Quit(string firstName, string lastName)
        {
            Console.WriteLine("I " + firstName + " " + lastName + ", Quit!");
        }
    }  
}

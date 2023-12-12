using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            IQuittable quittable = new Employee();

            employee.firstName = "Tanner";
            employee.lastName = "Vasquez";

            employee.sayName();
            quittable.Quit(employee.firstName, employee.lastName);
            Console.ReadLine();
        }
    }
}

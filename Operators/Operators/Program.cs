using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.id = 100;
            emp1.firstName = "Tanner";
            emp1.lastName = "Vasquez";

            Employee emp2 = new Employee();
            emp2.id = 101;
            emp2.firstName = "Nayeli";
            emp2.lastName = "Bernal";

            Console.WriteLine(emp1 == emp2);
            Console.ReadLine();
        }
    }
}

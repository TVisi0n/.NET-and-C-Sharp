using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int usersNumber1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("If you'd like to enter anoter number you can, it's optional.");
            int usersNumber2 = Convert.ToInt32(Console.ReadLine());

            int usersAnswer = Class1.Method(usersNumber1, usersNumber2);
            Console.WriteLine(usersAnswer);

            Console.ReadLine();
        }
    }
}

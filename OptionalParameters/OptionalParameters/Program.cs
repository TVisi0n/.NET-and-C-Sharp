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
            Class1 class1 = new Class1();

            Console.WriteLine("Please enter a number.");
            int usersNumber1 = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine("If you'd like to enter anoter number you can, it's optional.");
                int usersNumber2 = Convert.ToInt32(Console.ReadLine());

                int usersAnswer = class1.Method(usersNumber1, usersNumber2);
                Console.WriteLine(usersNumber1 + " times 3 plus " + usersNumber2 + " equals " + usersAnswer);
            }
            catch
            {
                Console.WriteLine("You did not input a number for the second number so we used your first choice again.");
                int usersAnswer = class1.Method(usersNumber1, usersNumber1);
                Console.WriteLine(usersNumber1 + " times 3 plus " + usersNumber1 + " equals " + usersAnswer);
            }
            


            Console.ReadLine();
        }
    }
}

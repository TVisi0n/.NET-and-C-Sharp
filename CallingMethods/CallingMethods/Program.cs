using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please choose to number to have 3 math operations done to them between 1 & 10.");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            int output1 = Class1.MathOp1(userChoice);
            int output2 = Class1.MathOp2(userChoice);
            int output3 = Class1.MathOp3(userChoice);

            Console.WriteLine(userChoice + " plus 5 equals: " + output1);
            Console.WriteLine(userChoice + " times 2 equals: " + output2);
            Console.WriteLine(userChoice + " minus 3 equals: " + output3);

            Console.ReadLine(); 
        }
    }
}

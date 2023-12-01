using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick any number to divide my list of numbers by.\nMy list of numbers include: 8, 16, 90, 28, 53.");
                int userChoice = Convert.ToInt32(Console.ReadLine());

                List<int> numbers = new List<int>() { 8, 16, 90, 28, 53 };
                foreach (int number in numbers)
                {
                    Console.WriteLine(number + " divide by " + userChoice + " is: " + number / userChoice);
                }

                Console.ReadLine();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide the list of numbers by 0, please choose another whole number.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please use a whole number.");
            }

            Console.ReadLine();
        }
    }
}

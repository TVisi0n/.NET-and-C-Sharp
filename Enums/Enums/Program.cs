using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week.");
                string userInput = Console.ReadLine();

                
                if (Enum.IsDefined(typeof(DaysOfTheWeek), userInput))
                {
                    Console.WriteLine("Yes that is a day of the week!");
                }
                else
                {
                    Console.WriteLine("Please enter a valid day of the week.");
                }
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();
        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        };
    }
}

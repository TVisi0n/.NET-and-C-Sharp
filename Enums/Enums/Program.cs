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

                DaysOfTheWeek day = DaysOfTheWeek.Saturday;


                DaysOfTheWeek result;
                if (Enum.TryParse(userInput, out result) && result == day)
                {
                    Console.WriteLine("Yes that is the correct day");
                }
                else
                {
                    Console.WriteLine("No that is not the correct day");
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

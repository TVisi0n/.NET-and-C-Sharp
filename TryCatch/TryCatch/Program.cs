using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age.");
                int userAge = Convert.ToInt32(Console.ReadLine());
                if (userAge == 0)
                {
                    Console.WriteLine("You cannot enter 0. Please press Enter and restart the program.");
                    Console.ReadLine();
                    return;
                }
                int yearBorn = 2023 - userAge;
                Console.WriteLine("You were born in the year {0}", yearBorn);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You cannot enter 0 or null, please try again.");
                return;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter a valid number and no decimals, please try again.");
            }
            catch (Exception)
            {
                Console.WriteLine("Oops something has gone wrong. Please press Enter and restart the program.");
                Console.ReadLine();
            }


            Console.ReadLine();
        }
    }
}

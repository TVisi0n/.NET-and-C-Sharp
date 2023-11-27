using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentTemp = 80;
            int roomTemp = 70;

            if (currentTemp == roomTemp)
            {
                Console.WriteLine("It is exactly room temperature.");
            }
            else if (currentTemp > roomTemp)
            {
                Console.WriteLine("It is warmer than room temperature.");
            }
            else if (roomTemp > currentTemp)
            {
                Console.WriteLine("Room temperature is warmer than current temperature.");
            }
            else
            {
                Console.WriteLine("It is not exactly room temperature.");
            }
            Console.ReadLine();
        }
    }
}

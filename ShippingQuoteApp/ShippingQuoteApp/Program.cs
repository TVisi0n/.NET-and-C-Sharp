using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Packagae Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight in lbs.");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Please enter the package width in inches.");
            int width = Convert.ToInt32(Console.ReadLine());
            if (width > 50)
            {
                Console.WriteLine("Package too wide to be shipped via Package Express. Have a good day");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Please enter the package height in inches.");
            int height = Convert.ToInt32(Console.ReadLine());
            if (height > 50)
            {
                Console.WriteLine("Package too tall to be shipped via Package Express. Have a good day");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Please enter the package length in inches.");
            int length = Convert.ToInt32(Console.ReadLine());
            if (length > 50)
            {
                Console.WriteLine("Package too long to be shipped via Package Express. Have a good day");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Your estimated total for shipping this package is:");
            int cost = width * height * length * weight / 100;
            Console.WriteLine("$" + cost);


            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace ArrayApp
{
    class Program
    {
        static void Main()
        {
            string[] nameArray = { "Tanner", "Erick", "Yoshi", "Connor" };

            Console.WriteLine("Please select an Array object 0 - 3");
            int userSelection = Convert.ToInt32(Console.ReadLine());
            if (userSelection >= 4)
            {
                Console.WriteLine("You did not enter a number between 0 and 3.\nPlease Reload the app and Try Again!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine(nameArray[userSelection]);
   

            int[] numArray = { 33, 41, 53, 91 };
            Console.WriteLine("Please select an Array object 0 - 3");
            int userSelection1 = Convert.ToInt32(Console.ReadLine());
            if (userSelection1 >= 4)
            {
                Console.WriteLine("You did not enter a number between 0 and 3.\nPlease Reload the app and Try Again!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine(numArray[userSelection1]);

            List<string> nameList = new List<string>();
            nameList.Add("Tanner");
            nameList.Add("Connor");
            nameList.Add("Yoshi");
            nameList.Add("Erick");

            Console.WriteLine("Please select a List object 0 - 3");
            int userselection2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nameList[userselection2]);


            Console.ReadLine();
        }
    }
}

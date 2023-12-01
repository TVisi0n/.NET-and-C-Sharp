using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6PartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1:

            // Creating an Array of names
            string[] names = { "Tanner says, ", "Erick says, ", "Yoshi says, ", "Neli says, " };

            // Gets user input
            Console.WriteLine("Please enter some text you would like us to say!");
            string userInput = Console.ReadLine();

            // Iterating through the names
            for (int i = 0; i < names.Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(names);
                sb.Append(userInput);
            }

            // Iterating through the names, appends them to the user input and outputs a message to the console
            // Part 3 as well

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + userInput);
            }

            Console.ReadLine();

            // Part 3

            int[] nums = { 5, 18, 63, 72, 91 };

            // Iterates every other number
            for (int i = 0; i <= nums.Length; i = i + 2)
            {
                Console.WriteLine(nums[i]);
            }

            Console.ReadLine();

            // Part 4

            List<string> fruits = new List<string>() { "apple", "banana", "pear", "orange", "mango" };

            Console.WriteLine("Enter a name of a fruit!");
            string fruitChoice = Console.ReadLine();

            // Iterates through each list item and determines if the condition is met
            foreach (string fruit in fruits)
            {
                if (fruitChoice == fruit)
                {
                    Console.WriteLine("You chose a fruit in my list. Congrats!");
                    break;
                }
                else if (fruitChoice != fruit)
                {
                    Console.WriteLine("You did not choose a fruit in my list. Sorry!");
                    break;
                }
            }

            Console.ReadLine();

            // Part 5

            List<string> games = new List<string>() { "Call of Duty", "Apex Legends", "Fortnite", "GTA 5", "Fortnite" };

            Console.WriteLine("Please enter a game name from the list.\nCall of Duty, Apex Legends, Fornite, GTA 5");
            string gameChoice = Console.ReadLine();

            foreach (string game in games)
            {
                if (gameChoice == game)
                {
                    Console.WriteLine("That game can be find in index/indicies ");
                }
                else if (gameChoice != game)
                {
                    Console.WriteLine("This game is not found in our list.");
                }
            }

            Console.ReadLine();

            // Part 6

            List<string> firstNames = new List<string>() { "Tanner", "Neli", "Yoshi", "Milo", "Bella" };

            foreach (string firstName in firstNames)
            {

            }

        }
    }
}

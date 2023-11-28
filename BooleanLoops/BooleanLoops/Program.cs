using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the Veggie?");
            string vegetable = Console.ReadLine();
            bool iguessed = vegetable == "broccoli";

            while (!iguessed)
            {
                switch (vegetable)
                {
                    case "tomato":
                        Console.WriteLine("You guessed tomato. Guess Again!");
                        Console.WriteLine("Guess the Veggie?");
                        vegetable = Console.ReadLine();
                        break;
                    case "cucumber":
                        Console.WriteLine("You guessed cucumber. Guess Again!");
                        Console.WriteLine("Guess the Veggie?");
                        vegetable = Console.ReadLine();
                        break;
                    case "green bean":
                        Console.WriteLine("You guessed green bean. Guess Again!");
                        Console.WriteLine("Guess the Veggie?");
                        vegetable = Console.ReadLine();
                        break;
                    case "broccoli":
                        Console.WriteLine("You guessed broccoli and that's correct, congrats!");
                        iguessed = true;
                        break;
                    default:
                        Console.WriteLine("That is incorrect. Please Guess Again!");
                        Console.WriteLine("Guess the Veggie?");
                        vegetable = Console.ReadLine();
                        break;
                }
            }

            Console.WriteLine("Guess the Veggie?");
            string veggie = Console.ReadLine();
            bool guessed = veggie == "broccoli";


            do
            {
                switch (veggie)
                {
                    case "tomato":
                        Console.WriteLine("You guessed tomato. Guess Again!");
                        Console.WriteLine("Guess the Veggie?");
                        veggie = Console.ReadLine();
                        break;
                    case "cucumber":
                        Console.WriteLine("You guessed cucumber. Guess Again!");
                        Console.WriteLine("Guess the Veggie?");
                        veggie = Console.ReadLine();
                        break;
                    case "green bean":
                        Console.WriteLine("You guessed green bean. Guess Again!");
                        Console.WriteLine("Guess the Veggie?");
                        veggie = Console.ReadLine();
                        break;
                    case "broccoli":
                        Console.WriteLine("You guessed broccoli and that's correct, congrats!");
                        guessed = true;
                        break;
                    default:
                        Console.WriteLine("That is incorrect. Please Guess Again!");
                        Console.WriteLine("Guess the Veggie?");
                        veggie = Console.ReadLine();
                        break;
                }
            }
            while (!guessed);

            Console.ReadLine();
        }
    }
}

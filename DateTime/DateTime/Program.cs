using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime CurrentTime = DateTime.Now;

            Console.WriteLine("Please enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            TimeSpan result = TimeSpan.FromHours(userInput);

            DateTime answer = CurrentTime.Add(result);

            Console.WriteLine("The current time plus {0} hours is: {1}", result, answer);

            Console.ReadLine();
        }
    }
}

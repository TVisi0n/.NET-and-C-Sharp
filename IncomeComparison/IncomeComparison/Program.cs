using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1, Please enter your hourly rate:");
            int p1hr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your hours worked per week:");
            int p1hw = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2, Please enter your hourly rate:");
            int p2hr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your hours worked per week:");
            int p2hw = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual salary of Person 1:");
            int p1ai = p1hr * p1hw * 52;
            Console.WriteLine(p1ai);

            Console.WriteLine("Annual salary of Person 2:");
            int p2ai = p2hr * p2hw * 52;
            Console.WriteLine(p2ai);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool whoMakesMore = p1ai > p2ai;
            Console.WriteLine(whoMakesMore);

            Console.ReadLine();
        }
    }
}

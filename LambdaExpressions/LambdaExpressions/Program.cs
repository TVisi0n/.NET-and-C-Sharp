using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Joe", "Tanner", "Nayeli", "Erick", "Chay", "Connor", "Joe", "Yoshi", "Hunter", "Han" };
            List<int> IDs = new List<int>() { 1, 3, 65, 14, 5, 4, 7, 10, 45, 2 };
            List<string> joeNames = new List<string>();

            foreach(string name in names)
            {
                if (name == "Joe")
                {
                    joeNames.Add(name);
                }
            }
            Console.WriteLine(String.Join("\n", joeNames));
            Console.ReadLine();

            List<string> NamesWithJoe = names.Where(x => x == "Joe").ToList();

            Console.WriteLine(String.Join("\n", NamesWithJoe));
            Console.ReadLine();

            List<int> IDGreaterThanFive = IDs.Where(x => x > 5).ToList();

            Console.WriteLine(String.Join("\n", IDGreaterThanFive));
            Console.ReadLine();
        }
    }
}

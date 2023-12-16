using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Tanner";
            Console.WriteLine("Hello, my name is {0} and I never want this variable to change!", name);

            var varInt = 3;
            Console.WriteLine("This is an example of var: {0}", varInt);

            Age age = new Age("21", "Tanner", "1515");


            Console.ReadLine();
        }
    }
}

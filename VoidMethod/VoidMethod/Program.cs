using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();

            int output = class1.Method(8, 9);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}

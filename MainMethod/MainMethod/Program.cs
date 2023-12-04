using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int operation = MathOperation.Method(4);
            Console.WriteLine(operation);

            double operation1 = MathOperation.Method(3.4);
            Console.WriteLine(operation1);

            int operation2 = MathOperation.Method("7");
            Console.WriteLine(operation2);

            Console.ReadLine();
        }
    }
}

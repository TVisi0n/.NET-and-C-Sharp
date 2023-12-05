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

            class1.Method(6, 8);

            class1.Method(x: 6, y: 8);
        }
    }
}

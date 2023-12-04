using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class MathOperation
    {
        public static int Method(int x)
        {
            return x * 3;
        }

        public static double Method(double x)
        {
            return x + 5.3;
        }

        public static int Method(string number)
        {
            int newnum = Convert.ToInt32(number);
            return newnum * 4;
        }

    }
}

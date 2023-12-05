using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Class1
    {
        public static int Method(int x, int y = 1)
        {
            return x * 3 + y;
        }
    }
}

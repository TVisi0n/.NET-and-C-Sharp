using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            divide div = new divide();

            Console.WriteLine("Please enter a number to be divided by 2.");
            int usersNumber = Convert.ToInt32(Console.ReadLine());

            div.MethodDiv(usersNumber, out int result);

            Console.WriteLine(result);
            Console.ReadLine();
        }

    }
}

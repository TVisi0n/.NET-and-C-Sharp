using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Employee
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if(emp1.id.Equals(emp2.id))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            if (!emp1.id.Equals(emp2.id))
            {
                return true;
            }
            return false;
        }
    }
}

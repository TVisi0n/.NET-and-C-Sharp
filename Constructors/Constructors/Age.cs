using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Age
    {
        string _myAge = "";
        string _myID = "";
        string _myName = "";

        public Age(string myAge) : this(myAge, "", "")
        {
        }

        public Age(string myAge, string myName) : this(myAge, myName, "")
        {
        }
        
        public Age(string myAge, string myName, string myID)
        {
            _myID = myID;
            _myName = myName;
            _myAge = myAge;
        }

    }
}

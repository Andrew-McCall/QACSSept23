using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Vehicle
    {

        public Vehicle() { }

        // overriding a virtual method. Virtual methods don't have to be overriden
        public override string? ToString()
        {
            return "Andrew's Vehicle";
        }

    }
}

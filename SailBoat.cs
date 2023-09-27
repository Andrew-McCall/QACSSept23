using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class SailBoat: Boat
    {

        public SailBoat() : base()
        { }

        // Error because boat has sealed ToString
        /*
        public override string? ToString()
        {

        }
        */

    }
}

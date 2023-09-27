using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class LawnMower : IDrivable
    {
        public void Drive()
        {
            System.Console.WriteLine("Brrrrrrr");
        }
    }
}

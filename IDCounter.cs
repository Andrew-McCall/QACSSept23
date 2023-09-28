using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class IDCounter
    {

        public List<int> IDs = new List<int>();

        public void AddNumber(Vehicle a)
        {
            IDs.Add(a.ID);
        }

    }
}

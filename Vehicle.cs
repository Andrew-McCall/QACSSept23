using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class Vehicle: IDrivable, IComparable<Vehicle>
    {

        public int ID { get; init; }
        public static int Counter = 0;

        public Vehicle() {

            Counter++; // Counter += 1
            ID = Counter;

        }

        public override string? ToString()
        {
            return "Andrew's Vehicle";
        }

        protected abstract decimal TaxCode();

        // this will force all children to make own implmentation
        public abstract void Drive();

        // 1 , 0 , -1 
        public int CompareTo(Vehicle? other)
        {
            if (other == null) return -1;
            return other.ID - this.ID; //other.ID.CompareTo(ID);
        }
    }
}

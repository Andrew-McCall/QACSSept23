using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class AqauicCar: Car
    {
        // Overload Constructor
        public AqauicCar(string reg) : base(reg) { }
        public AqauicCar(string model, string make, string reg) : base(model, make, reg) { }
        public AqauicCar() : base("Boaty", "MC", "144") { }

        public void Float()
        {
            Console.WriteLine("SPASLhshsh");
        }

        // Overloaded Parent Method
        public int Accelerate()
        {
            base.Speed += 25;
            return base.Speed;
        }

    }
}

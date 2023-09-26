using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Car
    {

        public int Speed { set; get; }
        public string Model { set; get; }
        public string Make { set; get; }
        public string Reg { set; get; }

        public Car(string model, string make, string reg)
        {
            Model = model;
            Make = make;
            Reg = reg;
            Speed = 0;
        }

        public int Accelerate(int power)
        {
            Speed += power;
            return Speed;
        }

        public void EmergencyBrake()
        {
            Speed = 0;
        }


    }
}

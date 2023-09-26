using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Car
    {

        // Properties
        private int Speed;

        // Manual (Custom) implentation
        public int GetSpeed()
        {
            return Speed;
        }

        public void SetSpeed(int speed)
        {
            if (speed > 0 && speed < 200)
            {
                Speed = speed;
            }
        }

        // Auto-implentated. 
        public string Model { set; get; }
        public string Make { set; get; }
        // Auto-implentated with setter restrictions
        public string Reg { protected set; get; }

        // Constructor
        public Car(string model, string make, string reg)
        {
            Model = model;
            Make = make;
            Reg = reg;
            Speed = 0;
        }

        // Overloaded 
        public Car(string reg) {
            Reg = reg;
            Speed = 0;
            Make = "Nissan";
            Model = "Micra";
        }

        // Methods
        public int Accelerate(int power)
        {
            Console.WriteLine("int");
            Speed += power;
            return Speed;
        }

        public int Accelerate(double power)
        {
            Console.WriteLine("double");
            Speed += (int)power;
            return Speed;
        }

        public void EmergencyBrake()
        {
            Speed = 0;
        }


    }
}

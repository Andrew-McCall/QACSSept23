using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Car: Vehicle
    { 

        private int _speed; // Backing Property, which holds the data
        public int Speed    // Public property which gives shortcut access
        {
            get { return _speed; }
            
            set { 
                if (value <= 200 && value >= 0)
                {
                    _speed = value;
                }
            }
        }


        private string _reg; 
        public string Reg
        {
            get { return _reg; }
            set
            {
                if (value.Length == 3)
                {
                    _reg = value;
                }
            }
        }


        // Auto-implentated. 
        public string Model { set; get; }
        public string Make { set; get; }
        

        // Constructor
        public Car(string model, string make, string reg) : base()
        {
            Model = model;
            Make = make;
            Reg = reg;
            Speed = 0;
        }

        // Overloaded 
        public Car(string reg) : base() 
        {
            Reg = reg;
            Speed = 0;
            Make = "Nissan";
            Model = "Micra";
        }

        // Methods
        public int Accelerate(int power)
        {
            Speed += power;
            return Speed;
        }

        public int Accelerate(double power)
        {
            Speed += (int)power;
            return Speed;
        }

        public void EmergencyBrake()
        {
            _speed = 0;
        }

        protected override decimal TaxCode()
        {
            return 0.25m;
        }

        public override void Drive()
        {
            System.Console.WriteLine("Beep beep");
        }
    }
}

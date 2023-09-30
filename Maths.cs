using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Maths
    {

        public static int StaticNumber = 10;
        public int ObjectNumber { get; set; }

        public Maths(int objectNumber)
        {
            ObjectNumber = objectNumber;
        }

        public int AddToStaticNumber()
        {
            // Increases static number by the object number
            // StaticNumber += ObjectNumber;
            StaticNumber = StaticNumber + ObjectNumber;
            return StaticNumber;
        }

    }
}

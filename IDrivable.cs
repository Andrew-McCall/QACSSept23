﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public interface IDrivable
    {

        public int Steer(int direction)
        {
            if (direction > 0)
            {
                Console.WriteLine("right");
            }
            else
            {
                Console.WriteLine("left");
            }
            return direction;
        }

        // Abstract and Public by default
        void Drive();
    }
}

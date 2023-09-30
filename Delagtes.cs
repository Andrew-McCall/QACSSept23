using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Delagtes
    {

        public int Double(int a)
        {
            return a * 2;
        }

        public static int Square(int a)
        {
            return a * a;
        }

        public void Display(int a)
        {
            Console.WriteLine(a);
        }

    }
}

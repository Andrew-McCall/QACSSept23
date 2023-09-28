using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class AndrewException: Exception
    {
        // new Exception("This is a detialed description")
        public AndrewException() : base("This is a detialed description")
        { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class SunRoofCar: Car
    {
        public SunRoofCar(string reg): base(reg) {
            this.IsRoofOpen = false;
        }

        public bool IsRoofOpen { get; set; }

        public bool ToggleRoof()
        {
            if (IsRoofOpen)
            {
                IsRoofOpen= false;
            }else
            {
                IsRoofOpen= true;
            }

            return IsRoofOpen;
        }



    }
}

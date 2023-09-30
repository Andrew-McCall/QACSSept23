using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class FishingBoat: Boat
    {

        public FishingBoat() : base( 2500 ) { }
        public FishingBoat(uint engineSize) : base( engineSize ) { }

        public override uint GetPrice()
        {
            uint price = base.GetPrice();

            if ( EngineSize is not null)
            {
                price *= (uint) EngineSize / 1000;
            }

            if (HasSails) {
                price += base.GetPrice();
            }

            return price;
        }

    }
}

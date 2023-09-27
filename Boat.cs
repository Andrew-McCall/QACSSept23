using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Boat: Vehicle
    {

        public bool HasSails { get; set; }

        // Add ? to value types to make them nullable
        public uint? EngineSize { get; set; }


        public Boat() : base()
        { 
            this.HasSails = true;
            this.EngineSize = null;
        }

        public Boat(uint engineSize) : base()
        {
            this.HasSails = false;
            EngineSize = engineSize;
        }

        public Boat(bool hasSails, uint? engineSize) : base()
        {
            HasSails = hasSails;
            EngineSize = engineSize;
        }

        public sealed override string ToString()
        {
            return $"Boat [Sails:{HasSails}, EngineSize:{EngineSize}]";
        }

        public virtual uint GetPrice()
        {
            return 10000_00;
        }

        protected override decimal TaxCode()
        {
            return 0.1m;
        }
    }
}

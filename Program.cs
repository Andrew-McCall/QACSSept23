
namespace ConsoleApp3
{
    public class Program
    {

        public static void Main(string[] args)
        {

            // Upcasting
            SailBoat sb = new SailBoat();
            Boat boat = sb;
            Vehicle vehicle = sb;
            Object obj3ct = vehicle;

            //vehicle = new Car("abv");
            Console.WriteLine(vehicle.ID);

            // DownCasting
            // might be unsafe
            // - cause an error if object is not actaully a sailboat
            SailBoat sb2 = (SailBoat)vehicle; 

            SailBoat? sb3 = vehicle as SailBoat; // will be null if not

            if (sb3 is null)
            {
                Console.WriteLine("vehicle was not a boat");
            }

            if (vehicle is Boat)
            {
                Console.WriteLine("vehicle was a boat");
            }
        }

    }
}

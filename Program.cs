
namespace ConsoleApp3
{
    public class Program
    {

        public static void Main(string[] args)
        {

            // TODAY
            // ArrayLists - Generics
            // Exceptions
            // Lambdas - LINQ

            // Garage Class
            // In the constuctor ask for the array length
            // Set each slot, ei store a vehicle
            // print them all (foreach)
            // find vehicle by id
            // EXT
            // use as and is to loop through the vehicles stored and treat each one differently

            Garage garage = new(3);

            garage.Store(0, new Boat());
            new Boat(); // This uses an id, then forgetten
            garage.Store(1, new Car("REG"));

            Console.WriteLine("PRINT ALL");
            garage.PrintAll();

            Console.WriteLine($"Get 1: {garage.Get(1)}");
            Console.WriteLine($"Get 2: {garage.Get(2)}");
            Console.WriteLine($"Get 3: {garage.Get(3)}");

            garage.UseAll();

            Console.WriteLine("PRINT ALL");
            garage.PrintAll();

            garage.AddSlot();
            garage.AddSlot();
            garage.AddSlot();
            garage.AddSlot();

            Console.WriteLine("PRINT ALL");
            garage.PrintAll();

            garage.StoreVehicle(new SunRoofCar("123"));
            garage.StoreVehicle(new SunRoofCar("123"));
            garage.StoreVehicle(new SunRoofCar("123"));

            Console.WriteLine("PRINT ALL");
            garage.PrintAll();

        }


    }
}


namespace ConsoleApp3
{
    public class Program
    {

        public static void Main(string[] args)
        {


            // Math.Round // dont need state. You dont need an object. Just CODE

            Vehicle v1 = new Boat();     // 1
            Vehicle v2 = new Car("reg"); // 2
            Vehicle v3 = new SailBoat(); // 3

            Console.WriteLine(Vehicle.Counter); // 3

            new Boat();                  // 4 - gets deleted

            Console.WriteLine(Vehicle.Counter); // 4

            Vehicle v4 = new Boat();     // 5

            Console.WriteLine(v1.ID);
            Console.WriteLine(v2.ID);
            Console.WriteLine(v3.ID);

            Console.WriteLine(v4.ID);

        }

    }
}

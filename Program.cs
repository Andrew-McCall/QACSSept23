
namespace ConsoleApp3
{
    public class Program
    {

        public static void Main(string[] args)
        {

            // Vehicle Class
            // Boat Class - Extends Vehicle
            // Car Class  - Extends Vehicle
            // Make two more class that extend car
            // Make one class that extends boat

            // Create a instance of each class
            // Try casting/polymorphism
            // Take note of what you have access to.

            // Have fun, add any behaviour you'd like.
            // Try anything new that comes to mind

            // EXT
            // Position struct
            // each class maniuplate the (vehicle's) position property unquiely


            /// TODAY
            // virtual
            // override
            // sealed

            // abstract

            // static

            // ToString Polymorphism
            Vehicle v1 = new Boat();
            // Object.ToString() returns the class name
            System.Console.WriteLine(v1.ToString());

            Vehicle v2 = new Boat(false, 50000);
            System.Console.WriteLine(v2.ToString());

            Object o = v2;
            System.Console.WriteLine(o.ToString());


            Boat b1 = new Boat();
            Boat b2 = new FishingBoat();
            Boat b3 = new SailBoat();

            Console.WriteLine(b1.GetPrice());
            Console.WriteLine(b2.GetPrice());
            Console.WriteLine(b3.GetPrice());

        }

    }
}


//using ConsoleApp3; // import everything that is in said namespace
// this file is in a "top-level namespace"

// Typically the name of your project. 
namespace ConsoleApp3
{
    public class Program
    {
        // Default Method/Entry Point
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            Car carOne = new Car("Leaf", "Nissan", "ABC");

            Console.WriteLine(carOne.Reg);
            Console.WriteLine(carOne.GetSpeed());

            carOne.Accelerate(7);

            Console.WriteLine(carOne.GetSpeed());

            Car carTwo = new Car("Leaf", "Nissan", "DFE");
            Car carThree = new Car("F150", "Ford", "123");

            Console.WriteLine(carTwo.Reg);
            Console.WriteLine(carThree.Reg);

            carThree.Accelerate(451);
            carThree.Accelerate(124);

            Console.WriteLine(carTwo.GetSpeed());
            Console.WriteLine(carThree.GetSpeed());

            carThree.EmergencyBrake();

            Console.WriteLine(carThree.GetSpeed());

            Console.WriteLine(carTwo.Accelerate(52));
            Console.WriteLine(carTwo.Accelerate(532));
            Console.WriteLine(carTwo.GetSpeed());

            Car carFour = new Car("abc");
            Console.WriteLine(carFour.Reg);
            Console.WriteLine(carFour.Make);
            Console.WriteLine(carFour.GetSpeed());
            Console.WriteLine(carFour.Model);

            carFour.Accelerate(7);
            carFour.Accelerate(7.0);
            carFour.Accelerate(7);


            // carFour.GetSpeed() = 523;
        }

    }
}

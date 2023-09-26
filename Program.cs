
//using ConsoleApp3; // import everything that is in said namespace
// this file is in a "top-level namespace"

// Overloading
// Manual Implentation
// Private vs Public
// Main Method

// Typically the name of your project. 
namespace ConsoleApp3
{
    public class Program
    {
        // Default Method/Entry Point
        public static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello world");

            Car carOne = new Car("Leaf", "Nissan", "ABC");

            Console.WriteLine(carOne.Reg);
            Console.WriteLine(carOne.Speed);

            carOne.Accelerate(7);

            Console.WriteLine(carOne.Speed);

            Car carTwo = new Car("Leaf", "Nissan", "DFE");
            Car carThree = new Car("F150", "Ford", "123");

            Console.WriteLine(carTwo.Reg);
            Console.WriteLine(carThree.Reg);

            carThree.Accelerate(451);
            carThree.Accelerate(124);

            Console.WriteLine(carTwo.Speed);
            Console.WriteLine(carThree.Speed);

            carThree.EmergencyBrake();

            Console.WriteLine(carThree.Speed);

            Console.WriteLine(carTwo.Accelerate(52));
            Console.WriteLine(carTwo.Accelerate(532));
            Console.WriteLine(carTwo.Speed);

            Car carFour = new Car("abc");
            Console.WriteLine(carFour.Reg);
            Console.WriteLine(carFour.Make);
            Console.WriteLine(carFour.Speed);
            Console.WriteLine(carFour.Model);

            carFour.Accelerate(7);
            carFour.Accelerate(7.0);
            carFour.Accelerate(7);


            // carFour.Speed = 523;
            */

            Car car = new Car("123");
            car.Speed = 87;
            Console.WriteLine(car.Speed);

            car.Speed = 525023;
            Console.WriteLine(car.Speed);

            // reg is 123
            Console.WriteLine(car.Reg);
            car.Reg = "321"; 
            Console.WriteLine(car.Reg);

            car.Reg = "3241";
            Console.WriteLine(car.Reg);

            // Implement all properties of car to be explict
            // (Make, Model) dont nessciallry need special rules

        }

    }
}

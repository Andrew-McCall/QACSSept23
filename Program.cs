
namespace ConsoleApp3
{
    public class Program
    {

        public static void Main(string[] args)
        {
            /// OOP Principles
            // Inhertance    
            // - Reusing the behaviour of a super class

            // Abstraction
            // - Setting rules on what is accessable (Access Modifiers)

            // Encapsulation
            // - Bundling data/behaviour into a class (or struct)

            // Polymorphism
            // - that a object can be many things. e.i a class of its heirarchy
            // *Override


            // Pass by Reference  - enums, structs, CLASSES
            SunRoofCar src = new("abc");
            src.Accelerate(10);
            Console.WriteLine(src.Speed); // 10

            Car car = src;
            Console.WriteLine(car.Speed); // 10
            car.Accelerate(10);
            Console.WriteLine(car.Speed); // 20

            src.Accelerate(100);
            Console.WriteLine(car.Speed); // 120

            Console.WriteLine(car == src);


            // Pass by Value - bool, char, int, float, 
            // because these are value types. 
            // they are cloned when passed
            int x = 0;
            int y = x; // y = 0 (not x)

            x += 99;
            Console.WriteLine(y);  // 0 becase y never changed

            double a = 0;
            double b = a;

            b += 9.53;
            Console.WriteLine(a);  // 0


            // Pass By Reference TWO
            Car c = new("123");
            Car d = c;

            c.Speed = 100;
            Console.WriteLine(d.Speed); // 100

            CarMaker("ANDREW", d);
            Console.WriteLine(d.Make); // ANDREW
            Console.WriteLine(c.Make); // ANDREW

            // Pass by Value TWO
            x = 99;
            y = 99;
            IntMaker(x, y);
            Console.WriteLine(x);

        }

        public static void CarMaker(string make, Car car)
        {
            car.Make = make;
        }

        public static void IntMaker(int a, int b)
        {
            a += b;
        }

    }
}

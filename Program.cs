
namespace ConsoleApp3
{
    public class Program
    {

        public static void Main(string[] args)
        {

            // Array (Immuatable)
            int[] myNumbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine(myNumbers);
            Console.WriteLine(myNumbers[0]); // Index of an array starts at 0
            Console.WriteLine(myNumbers[4]);
            Console.WriteLine(myNumbers[3]);

            myNumbers[0] = -100;
            Console.WriteLine(myNumbers[0]);

            Boat[] boats = new Boat[10]; // Create an empty arrray of 10 nulls
            Console.WriteLine(boats[0]);
            boats[0] = new Boat();
            Console.WriteLine(boats[0]);

            int[] empty = new int[8]; // eight 0s

            // eight slots in an array, each holding another array
            // Each row can hold different sized arrays
            int[][] ints = new int[8][];

            // {[{1,2,3,4,5}],[],[],[],[],[],[],[],[]}
            // int[0][3] = 4;

            // Fixed Width Mutlidimentional arra
            // All of the arrays in the first array, have the same length
            int[,] intt2 = new int[5, 4];

            // {[{0,0,0,0}],[{0,0,0,0}],[{0,0,0,0}],[{0,0,0,0}],[{0,0,0,0}]}

            ints[5] = new int[99];

            Console.WriteLine(ints[5][52]);
            Console.WriteLine(intt2[3,3]);

            ints[5][52] = 532;
            intt2[3, 3] = 812312;

            Console.WriteLine(ints[5][52]);
            Console.WriteLine(intt2[3, 3]);

            Vehicle[] vehicles = new Vehicle[3];
            vehicles[0] = new Boat();
            vehicles[1] = new Car("abc");
            vehicles[2] = new FishingBoat();

            Boat? b = vehicles[0] as Boat;
            if (b is not null)
            {
                Console.WriteLine(b.GetPrice());
            }

            
            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine(v.ToString());
            }

            /*
            for (int i = 0, i < vehicles.Length; i++)
            {
                Vehicle v = vehicles[i];
            }
            */

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
      
        }


    }
}


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

            // A list is a class which implements the collection interface
            // System.Collections.Generic. mihgt need to import via "using" at the top of the file
            List<int> myNumbers = new List<int>();

            // You can prepopulate Lists
            List<Vehicle> g = new List<Vehicle>() { new Car("123"), new Car("333") };

            myNumbers.Add(52);
            myNumbers.Add(45325232);
            myNumbers.Add(33);
            myNumbers.Add(-4123);

            foreach (int no in myNumbers)
            {
                Console.WriteLine(no);
            }

            myNumbers[3] = 9999;
            Console.WriteLine(myNumbers[3]);

            myNumbers.RemoveAt(3); // deletes by index (.Remove deletes by .equals)
            myNumbers.Sort();
            foreach (int no in myNumbers)
            {
                Console.WriteLine(no);
            }


            // Refactor Garage to use List<Vehicle>
            // UseAllDifferently
            // GetByVehicleId
            // AddInNextSlot
            // AddSlot
            // RemoveSlot


            Dictionary<string, int> words = new Dictionary<string, int>();

            words.Add("One", 1);
            words.Add("Two", 5);
            words.Add("Three", 652386);

            // [key] lists use a number index. Dictionarys use the first dataType given 
            Console.WriteLine(words["Two"]); // 5
            Console.WriteLine(words["Three"]); // 652386

            foreach (KeyValuePair<string, int> word in words)
            {
                Console.WriteLine($"{word.Value} : {word.Key}");
            }


            // It stores unquie data. hashes the object to store it. doesnt have an index
            HashSet<string> strings= new HashSet<string>();
            strings.Add("andrew");
            strings.Add("5224ejhe");
            strings.Add("andrew");
            strings.Add("jej523532he");
            strings.Add("jej523634634532he");
            strings.Add("24j41`43`");


            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }

            Garage garage = new Garage();

            Vehicle v1 = new Boat();
            Vehicle v2 = new Boat();
            Vehicle v3 = new SailBoat();
            Vehicle v4 = new Car("abc");
            Vehicle v5 = new SunRoofCar("123");

            garage.Store(v1);
            garage.Store(v3);
            garage.Store(v5);
            garage.Store(v4);
            garage.Store(v2);

            garage.PrintAll();

            garage.SortById();

            garage.PrintAll();

        }

    }
}

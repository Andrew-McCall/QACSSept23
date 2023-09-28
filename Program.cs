
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

        }


    }
}

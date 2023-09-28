
namespace ConsoleApp3
{
    public class Program
    {

        public static void Main(string[] args)
        {
            /*
            Delagtes d = new Delagtes();
            Func<int, int> myFunc = d.Double;
            */

            Func<int, int> myFunc = Delagtes.Square;
            Action<int> myAction = new Delagtes().Display;

            /*
            Predicate<string>
            Func<string, bool>

            Predicate<Vehicle, string>
            Func<Vehicle, string, bool>
            */

            int[] ints = { 12, 8, 7, 6, 4, 5 };

            foreach (int i in ints)
            { 

                myAction(i);
                myAction(myFunc(i));
                
            }

            Garage g = new Garage();
            g.Store(new Car("123")); // 1
            g.Store(new Boat());     // 2
            g.Store(new Car("abc")); // 3
            g.Store(new Car("321")); // 4
            g.Store(new Boat());     // 5
            g.Store(new Boat(false, 252343)); // 6

            g.ForEach(Vehicle.Display);

            List<Vehicle> returned = g.FindVehicle(Vehicle.IsIDGreaterThan5);

            foreach (Vehicle v in returned)
            {
                Console.WriteLine($"RETURNED: {v.ToString()}");
            }

            // Lambda - Annoymous function
            g.ForEach(v => Console.WriteLine(v));

            returned = g.FindVehicle(v => { return v.ID % 2 == 0; });
            foreach (Vehicle v in returned)
            {
                Console.WriteLine($"RETURNED: {v.ToString()}");
            }

            returned = g.FindVehicle(v =>
            {
                /*
                Vehicle? tv = v as Boat;
                return tv != null;
                */
                return v is Boat;
            });

            foreach (Vehicle v in returned)
            {
                Console.WriteLine($"BOATs: {v.ToString()}");
            }

            // Add a foreach (void action) to your garage
            // Add a filter/findVehicles to your garage (List<Vehicle> name (Func<Vehicle, bool>)

            // Try using static method as input for ^ loops - Display, IdGreaterThan5
            // Use Lambdas instead

            // EXT
            // Use a class based delgate
            // Update filter to use Predicate instead
            // Higher oder function. Function that will return a Func for you.
            // e.g GreaterX(5) - x => x > 5 | GreaterX(10) - x => x > 10

            int a = 0;
            int b = 10;

            try
            {
                throw new AndrewException();
                Console.WriteLine(b / a);

                throw new Exception("error message");
            }
            
            catch (AndrewException ae)
            {
                Console.WriteLine(ae);
            }
            catch (Exception ex)
            {
                Console.WriteLine("eoor");
            }
            finally // clean-up disconnecting
            {
                Console.WriteLine("Always Run");
            }

            try
            {
                throw new AndrewException();
            }
            catch (AndrewException ae)
            {
                Console.WriteLine(ae);
            }

        }

    }
}

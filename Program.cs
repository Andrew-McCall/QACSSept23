
namespace ConsoleApp3
{
    public class Program
    {

        public static void Main(string[] args)
        {

            // Vehicle is abstract so can't be created
            // Vehicle v = new Vehicle();

            Vehicle v1 = new Car("abc");
            Vehicle v2 = new Boat();

            LawnMower lm = new LawnMower();

            v1.Drive();
            v2.Drive();
            lm.Drive();

            IDrivable d1 = v1; // UpCast
            IDrivable d2 = v2; // UpCast
            IDrivable d3 = lm; // UpCast

            d3.Steer(-5235);
            // lm.Steer(); - default implmentation is not forced on children
            // Explict Casting
            ((IDrivable)lm).Steer(54);

            d3.Drive();

            // IDrivable - int Drive(int distance)
            // ISteerable - void Left(int degrees), void Right(int degrees)
            // IFlyable - int Up(int distance), int Down(int distance)
            // Expand two of the above interfaces. ( e.g IRemoteControl)
            
            // Add default implmentation to bool Park()
            // - you choose which Interface this is for

            // Try using them/Casting included
        }

    }
}

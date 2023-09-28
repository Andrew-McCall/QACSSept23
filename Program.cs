
namespace ConsoleApp3
{
    public class Program
    {

        public static void Main(string[] args)
        {
           
            Queue<int> ints1= new Queue<int>();
            ints1.Enqueue(10);
            ints1.Enqueue(20);
            ints1.Enqueue(30);
            ints1.Enqueue(40);



            Console.WriteLine(ints1.Dequeue());
            Console.WriteLine(ints1.Dequeue());
            Console.WriteLine(ints1.Dequeue());
            Console.WriteLine(ints1.Dequeue());

        }

    }
}

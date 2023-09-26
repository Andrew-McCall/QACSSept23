
using ConsoleApp3;

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
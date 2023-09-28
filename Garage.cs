using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Garage
    {

        private Vehicle[] _vehicles;

        public Garage(int length)
        {
            _vehicles = new Vehicle[length];
        }

        public Vehicle? Store(int index, Vehicle vehicle)
        {
            Vehicle? prev = _vehicles[index];
            _vehicles[index] = vehicle;
            return prev;
        }

        public void PrintAll()
        {
            foreach (Vehicle vehicle in _vehicles)
            {
                if (vehicle != null)
                {
                    Console.WriteLine(vehicle.ToString());
                }
                else
                {
                    Console.WriteLine("Empty Slot");
                }
            }
        }

        public Vehicle? Get(int id)
        {
            Vehicle? found = null;

            foreach (Vehicle vehicle in _vehicles)
            {
                //if (vehicle == null) continue;
                if (vehicle != null && vehicle.ID == id)
                {
                    found = vehicle;
                    break; // Quits loop and doesnt search other vehicles
                }
            }

            return found;
        }

        public void UseAll()
        {
            foreach (Vehicle vehicle in _vehicles)
            {
                if (vehicle != null)
                {

                    Console.WriteLine(vehicle.ToString());

                    Boat? b = vehicle as Boat;
                    if (b != null)
                    {
                        Console.WriteLine($"Price: {b.GetPrice()}");
                        continue;
                    }

                    SunRoofCar? src = vehicle as SunRoofCar;
                    if (src != null)
                    {
                        Console.WriteLine(src.IsRoofOpen);
                        continue;
                    }
                    
                    Car? c = vehicle as Car;
                    if (c != null)
                    {
                        Console.WriteLine(c.Reg);
                        c.Drive();
                        continue;
                    }

                    // Each type
                }
            }
        }

        public void AddSlot()
        {

            Vehicle[] prev = _vehicles;
            _vehicles = new Vehicle[prev.Length + 1];

            for (int i = 0; i< prev.Length; i++)
            {
                _vehicles[i] = prev[i];
            }

        }

        public Vehicle? RemoveVehicle(int index)
        {
            Vehicle? prev = _vehicles[index];
            _vehicles[index] = null;
            return prev;
        }

        public int? StoreVehicle(Vehicle vehicle)
        {
            int? index = null;

            for (int i = 0; i < _vehicles.Length; i++)
            {
                if (_vehicles[i] is null)
                {
                    _vehicles[i] = vehicle;
                    index = i;
                    break;
                }
            }

            return index;
        }

    }
}

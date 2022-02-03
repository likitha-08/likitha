using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public interface IVehicle
    {
        void Drive();
        bool Refuel(int amount);
    }

    public class Car : IVehicle
    {
        public int Fuel { get; set; }

        public Car(int fuel)
        {
            Fuel = fuel;
        }

        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("No fuel");
            }
        }

        public bool Refuel(int amount)
        {
            Fuel += amount;
            return true;
        }
    }
    class Interface
    {
        public static void Main7(string[] args)
        {
            Car car = new Car(0);
            Console.WriteLine("Enter the amount of fule:");
            int fuel = int.Parse(Console.ReadLine());
            if (car.Refuel(fuel))
            {
                car.Drive();
            }
        }
    }
}

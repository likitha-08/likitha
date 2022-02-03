using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ProblemHouse
    {
        static void Main(string[] args)
        {
            SmallApartment apartment = new SmallApartment();
            People person = new People("Rahul");
            apartment.door = new House.Door("black");
            person.house = apartment;
            person.ShowData();
        }
    }
    public class House
    {
        public int Area { get; set; }
        public Door door;

        public House(int area = 200)
        {
            Area = area;
        }

        public void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {Area} m2");
        }

        public Door GetDoor()
        {
            return door;
        }

        public class Door
        {
            public string Color { get; set; }

            public Door(string color = "brown")
            {
                Color = color;
            }

            public void ShowData()
            {
                Console.WriteLine($"I am a door, my color is {Color}");
            }
        }
    }

    public class SmallApartment : House
    {
        public SmallApartment(int area = 100) : base(area)
        {
        }
    }

    public class People
    {
        private string name;
        public House house { get; set; }

        public People(string name)
        {
            this.name = name;
        }

        public void ShowData()
        {
            Console.WriteLine($"A person whose name is {name}");
            Console.WriteLine("Data of house:");
            house.ShowData();
            Console.WriteLine("Data of door:");
            house.GetDoor().ShowData();
        }
    }
}

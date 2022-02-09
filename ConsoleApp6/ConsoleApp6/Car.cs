using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Car
    {
        struct Cars
        {
            public string CarModel;
            public int YearOfManufacturing;
        }

        static void Main7(string[] args)
        {
            int total = 2;
            Cars[] cars = new Cars[total];

            for (int i = 0; i < total; i++)
            {
                cars[i] = new Cars()
                {
                    CarModel = Console.ReadLine(),
                   YearOfManufacturing = int.Parse(Console.ReadLine())
                };
            }
            for (int i = 0; i < total - 1; i++)
            {
                for (int j = i + 1; j < total; j++)
                {
                    if (cars[i].YearOfManufacturing > cars[j].YearOfManufacturing)
                    {
                        var aux = cars[i];

                        cars[i] = cars[j];
                        cars[j] = aux;
                    }
                }
            }
            for (int i = 0; i < total; i++)
            {
                var car = cars[i];
                Console.WriteLine("CarModel: " + car.CarModel + ", " +
                    "Year of Manufacture: " + car.YearOfManufacturing);
            }
        }
    }
}

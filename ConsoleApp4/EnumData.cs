using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thrusday,
        Friday,
        Saturday,
        Sunday
    }

    class Parimeter
    {
        public enum Shapes
        {
            circle, square
        }

        public void PrintParameter(int val, Shapes shapes)
        {
            if (shapes == 0)
            {
                Console.WriteLine("Circumference of circle is:" + 2 * 3.14 * val);
            }
            else
            {
                Console.WriteLine("Circumference of square is:" + 4 * val);

            }
        }
    }
    class EnumData
    {
        public static void Main4()
        {
            Console.WriteLine("Value of Monday is " + WeekDays.Monday);
            Console.WriteLine("Value of Monday is " + (int)WeekDays.Monday);
            Parimeter p = new Parimeter();
            p.PrintParameter(3, Parimeter.Shapes.circle);
            p.PrintParameter(5, Parimeter.Shapes.square);

        }
    }
}

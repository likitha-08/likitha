using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class SquareArea
    {
        public class Square
        {
            private double X_Coordinate;
            private double Y_Coordinate;
            private double side;


            public Square(double X_Coordinate, double Y_Coordinate, double side)
            {
                this.X_Coordinate = X_Coordinate;
                this.Y_Coordinate = Y_Coordinate;
                this.side = side;
            }


            public void Move(double X, double Y)
            {
                X_Coordinate += X;
                Y_Coordinate += Y;
            }
            public void Scale(double scaleFactor)
            {
                side *= scaleFactor;
            }
            public override string ToString()
            {
                return string.Format("Corner({0},{1}) side {2}", X_Coordinate, Y_Coordinate, side);
            }
            public double GetPerimeter()
            {
                return 4 * side;
            }
            public double GetArea()
            {
                return side * side;
            }
        }
        static void Main(string[] args)
        {
            Square square = new Square(10, 5, 7);
            Console.WriteLine(string.Format("Square: {0}", square));
            square.Move(1, 2);


            Console.WriteLine(string.Format("Square: {0}", square));
            square.Scale(2);
            Console.WriteLine(string.Format("Square: {0}", square));


            Console.WriteLine(string.Format("Perimeter: {0}", square.GetPerimeter()));
            Console.WriteLine(string.Format("Area: {0}", square.GetArea()));
            Console.ReadKey();
        }

    }
}

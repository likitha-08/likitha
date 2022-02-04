using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public struct sampStru
    {
        private double val;
        public double Value
        {
            get { return val; }
            set { val = value; }
        }
        public double Read()
        {
            return double.Parse(Console.ReadLine());
        }
    }
    public struct Squares
    {
        sampStru ln;
        sampStru ht;

        public sampStru Length
        {
            get { return ln; }
            set { ln = value; }
        }
        public sampStru Breadth
        {
            get { return ht; }
            set { ht = value; }
        }
        public void newSquares()
        {
            sampStru rct = new sampStru();

            Console.WriteLine("\nInput the dimensions of the Rectangle: ");
            ln = sqrLength();
            Console.Write("breadth : ");
            ht.Value = rct.Read();
        }
        public sampStru sqrLength()
        {
            sampStru rct = new sampStru();

            Console.Write("length : ");
            rct.Value = rct.Read();
            return rct;
        }
    }
    class Square
    {
        static void Main()
        {
            Console.Write("\n\nMethod that returns a structure  :\n");
            var Sqre = new Squares();
            Sqre.newSquares();
            Console.WriteLine();
            Console.WriteLine("Perimeter and Area of the rectangle :");
            Console.WriteLine("Length:    {0}", Sqre.Length.Value);
            Console.WriteLine("Breadth:    {0}", Sqre.Breadth.Value);
            Console.WriteLine("Perimeter: {0}", (Sqre.Length.Value + Sqre.Breadth.Value) * 2);
            Console.WriteLine("Area:      {0}\n", Sqre.Length.Value * Sqre.Breadth.Value);
        }
    }
}

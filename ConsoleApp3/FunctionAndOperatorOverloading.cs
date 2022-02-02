﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class calculator
    {
        public int number1, number2;
        public calculator(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
        }
        public static calculator operator +(calculator c1)
        {
            c1.number1 = +c1.number1;
            c1.number2 = +c1.number2;
            return c1;
        }
        public void print()
        {
            Console.WriteLine("Number 1 :-" + number1);
            Console.WriteLine("Number 2 :-" + number2);

        }
    }
        class FunctionAndOperatorOverloading
    {
        public void sum()
        {
            int a = 5, b = 7;
            Console.WriteLine(a + b);
        }
        //function overloading
        public void sum(int a = 5, int b = 7)
        {
            Console.WriteLine(a + b);
        }
        public void sum(int a = 5, int b = 7, int c = 9)
        {
            Console.WriteLine(a + b + c);
        }
        public void sum(float a = 5, int b = 7, int c = 9)
        {
            Console.WriteLine(a + b + c);
        }

        static void Main10()
        {
            calculator calculator = new calculator(15, 25);
            calculator = +calculator;
            calculator.print();
            Console.ReadLine();

        }
    }
}

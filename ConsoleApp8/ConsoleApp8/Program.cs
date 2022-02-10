using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp8
{
    class Program
    {
        static void Main1(string[] args)
        {
                Thread work1Thread = new Thread(Work1);
                Thread work2Thread = new Thread(Work2);
                work1Thread.Start();
                work2Thread.Start();
                Console.ReadLine();
            }
            static void Work1()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Work 1 is called" + i.ToString());
                }

            }
            static void Work2()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Work 2 is called" + i.ToString());
                }
            }
        }
    }

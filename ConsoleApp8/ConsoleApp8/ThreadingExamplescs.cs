using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp8
{
    class ThreadingExamplescs
    {
        static void Main2(string[] args)
        {
            Thread thread = new Thread(MethodJoin);
            Console.WriteLine(thread.ThreadState);
            thread.Start();
            Console.WriteLine(thread.ThreadState);
            thread.Join();
            Console.WriteLine(thread.ThreadState);
            Console.WriteLine("Work completed");
        }

        static void MethodJoin()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Work in progress");
            }
        }
    }
}

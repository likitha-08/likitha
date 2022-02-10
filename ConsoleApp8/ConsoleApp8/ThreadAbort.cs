using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp8
{
    class ThreadAbort
    {
        static void Main10(string[] args)
        {
            Thread thread = new Thread(MethodJoin);
            thread.Start();
            thread.Join();
            thread.Abort();
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

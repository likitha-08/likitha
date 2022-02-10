using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace ConsoleApp8
{
    class ThreadProperties
    {
        internal class ExampleofThreadJoin
        {
            static void Main4(string[] args)
            {
                Stopwatch stwatch = new Stopwatch();
                stwatch.Start();

                Thread oThread = new Thread(ProcessSleep);
                oThread.Start();
                oThread.Join();
                stwatch.Stop();
                TimeSpan ts = stwatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
                Console.WriteLine(elapsedTime);
                Console.WriteLine("WOrk completed");
            }

            static void MethodJoin()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Work in progress");
                }
            }
            static void ProcessSleep()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Work in progress");
                    Thread.Sleep(4000);//4 second
                }
            }
        }
    }
}

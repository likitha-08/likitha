using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class FileHandling
    {
        static void Main3(string[] args)
        {
            /*
            StreamWriter sw = new StreamWriter("D://FileWrite//demo.txt");
            sw.WriteLine("writing value in a file");
            //write in output steam
            sw.Flush();
            sw.Close();
            Console.WriteLine("Hello World!");
            */
            StreamReader sr = new StreamReader("D://FileWrite//demo.txt");

            //this is used to specify from where to start reading input stream
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();

            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();


        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class BinaryReader1
    {
        static void Main(string[] args)
        {
            FileStream fout = new FileStream("demo.txt", FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(fout);
            string name = "sample";
            bw.Write(name);
            bw.Close();

            FileStream fin = new FileStream("demo.txt", FileMode.Open);
            BinaryReader br = new BinaryReader(fin);
            br.BaseStream.Seek(0, SeekOrigin.Begin);
            //  string sample = br.ReadString();
            Console.WriteLine(br.ReadString());
            br.Close();

        }
    }
}

    

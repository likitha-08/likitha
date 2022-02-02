using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class SampleC
    {
        int a, b;
        //Default Constructor
        public SampleC()
        {

        }
        ~SampleC()
        {

        }
        //parametrized constructor
        public SampleC(int _a, int _b)
        {
            a = _a;
            b = _b;
        }

    }
    class ConstructorVsDeconstructor
    {
        static void Main7(string[] args)
        {
            SampleC ObjSampleC = new SampleC();
            Console.ReadLine();
        }
    }
}

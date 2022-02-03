using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    abstract class SampleA
    {
        public SampleA()
        {

        }

        abstract public void show();

    }
    class SampleB : SampleA
    {
        public SampleB()
        {

        }
        //overriding
        public override void show()
        {

        }
    }

    class Abstractclasses
    {
        static void Main4(string[] args)
        {
            SampleB b = new SampleB();
        }
    }
}

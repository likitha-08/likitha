using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Largest
    {
        static void Main(string[] args)
        {
            int num,i,j = 0, lrg, lrg2;
            int[] arr1 = new int[100];

            Console.Write("Size of  the array : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input elements in the array :\n", num);
            for (i = 0; i < num; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            lrg = 0;

            for (i = 0; i < num; i++)
            {
                if (lrg < arr1[i])
                {
                    lrg = arr1[i];
                    j = i;
                }
            }
            lrg2 = 0;
            for (i = 0; i < num; i++)
            {
                if (i == j)
                {
                    i++; 
                    i--;
                }
                else
                {
                    if (lrg2 < arr1[i])
                    {
                        lrg2 = arr1[i];
                    }
                }
            }

            Console.Write("Second largest element in the array is :  {0} \n", lrg2);
            Console.ReadLine();
        }
    }
}

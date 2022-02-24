using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main1(string[] args)
        {
            string str;
            int i, len, vowel, cons;

            Console.Write("\nCount the total number of vowel or consonant :\n");
            Console.Write("Input the string :\n ");
            str = Console.ReadLine();

            vowel = 0;
            cons = 0;
            len = str.Length;

            for (i = 0; i < len; i++)
            {

                if (str[i] == 'a'||str[i] == 'e'||str[i] == 'i'||str[i] == 'o'||str[i] == 'u'||str[i] == 'A'||str[i] == 'E'||str[i] == 'I'||str[i] == 'O'||str[i] == 'U')
                {
                    vowel++;
                }
                else if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    cons++;
                }
            }
            Console.Write("total number of vowel in the string : {0}\n", vowel);
            Console.Write("total number of consonant in the string : {0}\n", cons);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Palindrome
    {
        static bool isPalRec(String str, int s, int e)
        {
            if (s == e)
                return true;

            if ((str[s]) != (str[e]))
                return false;

            if (s < e + 1)
                return isPalRec(str, s + 1,
                                e - 1);
            return true;
        }

        static bool isPalindrome(String str)
        {
            int n = str.Length;
            if (n == 0)
                return true;

            return isPalRec(str, 0, n - 1);
        }
        public static void Main5()
        {
            Console.WriteLine("enter the string:");
            string text = Console.ReadLine();
            Console.WriteLine(isPalindrome(text));
        }
    }
}

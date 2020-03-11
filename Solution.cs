using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankEnvironment
{
    class Solution
    {
        static void Main(string[] args)
        {
            long n = 10;
            string s = "aba";
            long result = repeatedString(s, n);
            Console.WriteLine("Repetition: " + result);
            Console.Read();

        }
        static long repeatedString(string s, long n)
        {
            double repeat = 0;
            foreach (char c in s)
            {
                if (c == 'a')
                {
                    repeat++;
                }
            }
            repeat = (repeat * (n / s.Length));
            for (int i = 0; i < n % s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    repeat++;
                }
            }
            return Convert.ToInt64(repeat);
        }
    }
}

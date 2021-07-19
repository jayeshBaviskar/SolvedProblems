using System;
using System.Collections.Generic;

namespace HackerRank_BeautifulNumber
{
    internal class Program
    {
        private static int[] arr = new int[200];
        private static void Main(string[] args)
        {
            for (int i = 0; i < 200; i++)
            {
                arr[i] = new int();
            }
        }

        private static HashSet<int> set = new HashSet<int>();
        private static void Generate(int num)
        {
            if (num < arr.Length)
            {
                if (arr[num] == 1)
                {
                    // beautiful number
                }
                else if (arr[num] == -1)
                {
                    // not a beautiful number
                }
                else
                {
                    // unknown
                }
            }

            String numstr = num.ToString();
            while (!set.Contains(num))
            {

            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace _3_LongestSubstringWithoutRepeatingCharacters
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //            Console.WriteLine(LengthOfLongestSubstring("bpfbhmipx"));
            //           Console.Read();

            String str = "geeksforgeeks";
            Console.WriteLine("The input string is " + str);
            int len = LengthOfLongestSubstring(str);
            Console.WriteLine("The length of "
                               + "the longest non repeating character is " + len);
                       Console.Read();
        }


        
        public static int LengthOfLongestSubstring(string str)
        {

            int res = 0; 

            int[] lastIndex = new int[256];
            for (int ind = 0; ind < 256; ind++)
            {
                lastIndex[ind] = -1;
            }

            int i = 0;

            for (int j = 0; j < str.Length; j++)
            {
                i = Math.Max(i, lastIndex[str[j]] + 1);
             
                res = Math.Max(res, j - i + 1);
                
                lastIndex[str[j]] = j;
            }
            return res;
        }
    }
}
using System;
using System.Collections.Generic;

namespace First_non_Repeating_Character
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("a", 1);
            
            Console.WriteLine("Result " + FirstNonRepeatingCharacter("lmnopqldsafmnopqsa"));
        }

        public static int FirstNonRepeatingCharacter(string str)
        {
            int[] arr = new int[26];
            foreach (char s in str)
            {
                int index = ((int)s) - ((int)'a');
                arr[index] += 1;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if ((arr[((int)str[i]) - ((int)'a')]) == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
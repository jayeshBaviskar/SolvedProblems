using System;
using System.Collections.Generic;

namespace _17._Letter_Combinations_of_a_Phone_Number
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<String> results = letterCombinations("23");
            Console.WriteLine(results.ToString());
            Console.Read();
        }

        public static List<String> letterCombinations(String digits)
        {
            String[] mapping = { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

            List<String> result = new List<String>();
            if (digits == null || digits.Length == 0)
            {
                return result;
            }

            String chars = mapping[Convert.ToInt32(digits[0].ToString())];
            for (int i = 0; i < chars.Length; i++)
            {
                result.Add(chars[i].ToString());
            }

            for (int i = 1; i < digits.Length; i++)
            {
                List<String> temp = new List<String>();
                String option = mapping[Convert.ToInt32(digits[i].ToString())];

                for (int j = 0; j < result.Count; j++)
                {
                    for (int p = 0; p < option.Length; p++)
                    {
                        temp.Add((result[j]) + (option[p]));
                    }
                }

                result.Clear();
                result.AddRange(temp);
            }

            return result;
        }
    }
}
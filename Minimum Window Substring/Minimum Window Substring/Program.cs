using System;

namespace Minimum_Window_Substring
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            Console.WriteLine(MinWindow("ADOBECODEBANC","ABC"));
        }

        public static string MinWindow(string s, string t)
        {
            int start = 0, end = 0, count = t.Length;
            var freq = new int[128];
            var result = string.Empty;

            foreach (var ch in t)
            {
                freq[ch]++;
            }

            while (end < s.Length)
            {
                if (freq[s[end]] > 0)
                {
                    count--;
                }
                freq[s[end]]--;
                end++;

                while (count == 0)
                {
                    if (string.IsNullOrEmpty(result) || end - start < result.Length)
                    {
                        result = s.Substring(start, end - start);
                    }

                    if (freq[s[start]] == 0)
                    {
                        count++;
                    }
                    freq[s[start]]++;
                    start++;
                }
            }
            return result;
        }
    }
}
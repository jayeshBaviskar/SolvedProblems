using System;
using System.Collections.Generic;

namespace LengthOfEachScene
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            String s = "a, b, a, b, c, b, a, c, a, d, e, f, e, g, d, e, h, i, j, h, k, l, i, j";
            s = s.Replace(",", String.Empty);
            s = s.Replace(" ", String.Empty);
            List<int> lst = partitionLabels(s);

            foreach (var item in lst)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.Read();
        }

        private static List<int> partitionLabels(string S)
        {
            Dictionary<char, int> m = new Dictionary<char, int>();
            for (int i = 0; i < S.Length; i++)
            {
                m[S[i]] = i;
            }

            List<int> result = new List<int>();
            int left = 0;
            int right = 0;
            for (int i = 0; i < S.Length; i++)
            {
                right = max(right, m[S[i]]);
                if (right == i)
                {
                    result.Add(1 + right - left);
                    left = right + 1;
                }
            }
            return result;
        }

        private static int max(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
}
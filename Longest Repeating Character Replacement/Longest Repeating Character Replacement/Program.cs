using System;

namespace Longest_Repeating_Character_Replacement
{
    internal class Program
    {
        
        public static int findLen(string A, int n,
                                int k, char ch)
        {
            int maxlen = 1;
            int cnt = 0;
            int l = 0, r = 0;

            // traverse the whole string
            while (r < n)
            {
                // if character is
                // not same as ch
                // increase count
                if (A[r] != ch)
                {
                    ++cnt;
                }

                // While count > k traverse
                // the string again until
                // count becomes less than
                // k and decrease the
                // count when characters
                // are not same
                while (cnt > k)
                {
                    if (A[l] != ch)
                    {
                        --cnt;
                    }
                    ++l;
                }

                // length of substring
                // will be rightIndex -
                // leftIndex + 1.
                // Compare this with the maximum
                // length and return maximum length
                maxlen = Math.Max(maxlen, r - l + 1);
                ++r;
            }
            return maxlen;
        }

        // method which returns
        // maximum length of substring
        public static int answer(string A, int n, int k)
        {
            int maxlen = 1;
            for (int i = 0; i < 26; ++i)
            {
                maxlen = Math.Max(maxlen,
                findLen(A, n, k, (char)(i + 'A')));

                maxlen = Math.Max(maxlen,
                findLen(A, n, k, (char)(i + 'a')));
            }
            return maxlen;
        }

        // Driver Method
        public static void Main(string[] args)
        {
            int n = 5, k = 2;
            string A = "ABCBA";
            Console.WriteLine("Maximum length = "
                            + answer(A, n, k));

            n = 6;
            k = 4;
            string B = "HHHHHH";
            Console.WriteLine("Maximum length = "
                            + answer(B, n, k));

            Console.Read();
        }
    }
}
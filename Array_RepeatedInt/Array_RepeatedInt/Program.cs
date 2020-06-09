using System;

namespace Array_RepeatedInt
{
    internal class Program
    {
        private class Pair
        {
            public int x;
            public int y;

            public Pair(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public override string ToString()
            {
                return x + " " + y;
            }
        }

        private static Pair lengthOfRepeatedSeq(int[] a)
        {
            if (a.Length == 0) return new Pair(0, 0);
            int o = a[0];
            int s = 0;
            int e = a.Length - 1;
            while (s < e)
            {
                int m = (s + e) / 2;
                if (a[m] >= m + o) s = m + 1; // if a[m] = m + o, there is no repeating character in [s..m]
                else e = m; // if a[m] < m, there is a repeating character in [s..m]
            }
            return new Pair(a[s], a.Length - (a[a.Length - 1] - o));
        }

        private static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 4, 4, 5, 6 };
            Console.WriteLine(lengthOfRepeatedSeq(arr).ToString());
            Console.Read();
        }
    }
}
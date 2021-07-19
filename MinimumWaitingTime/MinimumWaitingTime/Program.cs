using System;

namespace MinimumWaitingTime
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] queries = new int[] { 3, 2, 1, 2, 6 };
            int expected = 17;
            Console.WriteLine(new Program().MinimumWaitingTime(queries));
        }

        public int MinimumWaitingTime(int[] queries)
        {
            int result = 0;
            int op = 0;
            Array.Sort(queries);
            // 1, 2, 2, 3, 6
            for (int i = 0; i < queries.Length; i++)
            {
                if (i > 0)
                {
                    result += queries[i - 1];
                    op += result;
                }
            }
            return op;
        }
    }
}
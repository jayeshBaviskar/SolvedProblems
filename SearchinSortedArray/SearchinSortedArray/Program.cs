namespace SearchinSortedArray
{
    using System;

    internal class Program
    {
        private static void search(int[,] mat,
                                int n, int x)
        {
            int i = 0, j = n - 1;

            while (i < n && j >= 0)
            {
                if (mat[i, j] == x)
                {
                    Console.Write("n Found at "
                                + i + ", " + j);
                    return;
                }

                if (mat[i, j] > x)
                    j--;
                else
                    i++;
            }

            Console.Write("n Element not found");
            return;
        }

        // driver program to test above function
        public static void Main()
        {
            int[,] mat = {   { 10, 20, 30, 40 },
                             { 20, 25, 35, 45 },
                             { 27, 30, 40, 48 },
                             { 32, 33, 45, 50 } };

            search(mat, 4, 33);
            Console.Read();
        }
    }
}
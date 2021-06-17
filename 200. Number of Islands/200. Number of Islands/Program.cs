using System;

namespace _200.Number_of_Islands
{
    internal class Program
    {
        private int[,] matrix = {
                { 1,1,1,1,0},
                { 1,1,0,1,0},
                { 1,1,0,0,0},
                { 0,0,0,0,0}
            };

        private int col = 5;
        private int row = 4;

        private static void Main(string[] args)
        {
            Program prog = new Program();
            Console.WriteLine("Total Number of Islands are : " + prog.GetNumberofInslands());
            Console.Read();
        }

        private int GetNumberofInslands()
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            int result = 0;

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (matrix[r, c] == 1)
                    {
                        NumberofIslandUtil(r, c);
                        ++result;
                    }
                }
            }

            return result;
        }

        private void NumberofIslandUtil(int r, int c)
        {
            if (matrix[r, c] == 1)
            {
                matrix[r, c] = 2;

                if (r > 0)
                {
                    NumberofIslandUtil(r - 1, c);
                }
                if (r < (row - 1))
                {
                    NumberofIslandUtil(r + 1, c);
                }
                if (c > 0)
                {
                    NumberofIslandUtil(r, c - 1);
                }
                if (c < (col - 1))
                {
                    NumberofIslandUtil(r, c + 1);
                }
            }
        }
    }
}
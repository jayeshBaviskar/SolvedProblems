using System;

namespace _1s_and_0s
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] grid = new int[5, 5] {
                { 1, 1, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 1, 0, 1, 1, 0 },
                { 1, 1, 1, 1, 0 } };

            Console.WriteLine("Answer: " + GetNumberofIslands(grid));
            Console.Read();
        }

        private static int GetNumberofIslands(int[,] grid)
        {
            int numberOfInslands = 0;
            if (grid == null)
            {
                return 0;
            }

            int row = grid.GetLength(0);
            int col = grid.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        numberOfInslands += InterativeCount(grid, i, j);
                    }
                }
            }

            return numberOfInslands;
        }

        private static int InterativeCount(int[,] grid, int i, int j)
        {
            int row = grid.GetLength(0);
            int col = grid.GetLength(1);

            if (i < 0 || i >= row)
            {
                return 0;
            }

            if (j < 0 || j >= col)
            {
                return 0;
            }

            if (grid[i, j] == 0)
            {
                return 0;
            }

            grid[i, j] = 0;
            InterativeCount(grid, i, j - 1);
            InterativeCount(grid, i, j + 1);
            InterativeCount(grid, i - 1, j);
            InterativeCount(grid, i + 1, j);

            return 1;
        }
    }
}
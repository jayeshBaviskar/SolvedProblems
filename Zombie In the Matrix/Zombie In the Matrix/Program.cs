using System;
using System.Collections.Generic;
using System.Drawing;

namespace Zombie_In_the_Matrix
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] matrix = new int[,] { { 0, 1, 1, 0, 1 },
                                         { 0, 1, 0, 1, 0 },
                                         { 0, 0, 0, 0, 1 },
                                         { 0, 1, 0, 0, 0 },
                                         { 0, 0, 0, 0, 0 },
                                         { 0, 0, 0, 0, 0 }};

            int totalHours = 0;

            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            int peoples = 0;

            List<Point> zombies = new List<Point>();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        ++peoples;
                    }
                    else
                    {
                        zombies.Add(new Point(i, j));
                    }
                }
            }

            int[,] delta = new int[,] { { -1, 0 }, { 1, 0 }, { 0, -1 }, { 0, 1 } };

            while (peoples > 0)
            {
                ++totalHours;
                int size = zombies.Count;

                for (int i = 0; i < size; i++)
                {
                    Point p = zombies[i];

                    for (int j = 0; j < delta.GetLength(0); j++)
                    {
                        int convertedZombies = FindHours(matrix, p.X + delta[j, 0], p.Y + delta[j, 1], row, col);
                        if (convertedZombies > 0)
                        {
                            zombies.Add(new Point(p.X + delta[j, 0], p.Y + delta[j, 1]));
                        }

                        peoples = peoples - convertedZombies;
                    }
                }

                PrintMatrix(matrix);
                Console.WriteLine();
                //Console.Read();
            }

            Console.WriteLine("Total Hours " + totalHours);
            Console.Read();
        }

        private static void PrintMatrix(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int FindHours(int[,] matrix, int i, int j, int row, int col)
        {
            if (i < 0 || i >= row)
            {
                return 0;
            }

            if (j < 0 || j >= col)
            {
                return 0;
            }

            if (matrix[i, j] == 0)
            {
                matrix[i, j] = 1;
                return 1;
            }
            return 0;
        }
    }
}
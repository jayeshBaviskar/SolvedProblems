using System;
using System.Collections.Generic;


namespace Graph_Operations
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] input = {
            {1, 0, 0, 1, 0},
            {1, 0, 1, 0, 0},
            {0, 0, 1, 0, 1},
            {1, 0, 1, 0, 1},
            {1, 0, 1, 1, 0},
        };
            int[] expected = { 1, 2, 2, 2, 5 };
            List<int> output = Program.RiverSizes(input);
            for (int i = 0; i < output.Count; i++)
            {
                Console.Write(" " + output[i]);
            }
        }

        private class Node
        {
            public int i;
            public int j;

            public Node(int i, int j)
            {
                this.i = i;
                this.j = j;
            }
        }

        public static List<int> RiverSizes(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            List<int> result = new List<int>();

            bool[,] isVisited = new bool[row, col];
            int sum = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sum = 0;
                    Queue<Node> queue = new Queue<Node>();
                    if (isSafe(row, col, isVisited, i, j, matrix))
                    {
                        queue.Enqueue(new Node(i, j));

                        while (queue.Count != 0)
                        {
                            Node node = queue.Dequeue();
                            ++sum;

                            isVisited[node.i, node.j] = true;
                            // Top
                            if (isSafe(row, col, isVisited, node.i, node.j - 1, matrix))
                            {
                                queue.Enqueue(new Node(node.i, node.j - 1));
                            }
                            // left
                            if (isSafe(row, col, isVisited, node.i - 1, node.j, matrix))
                            {
                                queue.Enqueue(new Node(node.i - 1, node.j));
                            }
                            // Right
                            if (isSafe(row, col, isVisited, node.i + 1, node.j, matrix))
                            {
                                queue.Enqueue(new Node(node.i + 1, node.j));
                            }
                            // Botton
                            if (isSafe(row, col, isVisited, node.i, node.j + 1, matrix))
                            {
                                queue.Enqueue(new Node(node.i, node.j + 1));
                            }
                        }
                        if (sum > 0)
                        {
                            result.Add(sum);
                            sum = 0;
                        }
                    }
                }
            }
            if (sum > 0)
            {
                result.Add(sum);
            }

            return result;
        }

        public static bool isSafe(int row, int col, bool[,] isVisited, int i, int j, int[,] matrix)
        {
            return ((i >= 0) && (j >= 0) && (i < row) && (j < col) && !isVisited[i, j] && (matrix[i, j] == 1));
        }
    }
}
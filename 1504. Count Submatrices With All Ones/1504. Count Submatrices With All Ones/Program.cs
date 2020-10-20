using System;
using System.Collections.Generic;

namespace _1504._Count_Submatrices_With_All_Ones
{
    internal class Program
    {
        private class pair
        {
            public int first, second;

            public pair(int first, int second)
            {
                this.first = first;
                this.second = second;
            }
        }

        // Function to find required prefix-count for
        // each row from right to left
        private static void findPrefixCount(int[,] p_arr,
                                    Boolean[,] arr)
        {
            for (int i = 0; i < p_arr.GetLength(0) ; i++)
            {
                for (int j = p_arr.GetLength(1) - 1; j >= 0; j--)
                {
                    if (!arr[i, j])
                        continue;

                    if (j != p_arr.GetLength(1) - 1)
                        p_arr[i, j] += p_arr[i, j + 1];

                    p_arr[i, j] += arr[i, j] == true ? 1 : 0;
                }
            }
        }

        // Function to count the number of
        // sub-matrices with all 1s
        private static int matrixAllOne(Boolean[,] arr)
        {
            // Array to store required prefix count of
            // 1s from right to left for boolean array
            int[,] p_arr = new int[arr.GetLength(0), arr.GetLength(1)];

            findPrefixCount(p_arr, arr);
            DisplayMatrix(p_arr);

            // variable to store the final answer
            int totalMatrices = 0;

            /*  Loop to evaluate each column of
                the prefix matrix uniquely.
                For each index of a column we will try to
                determine the number of sub-matrices
                starting from that index
                and has all 1s */
            for (int col = 0; col < arr.GetLength(0); col++)
            {
                int row = arr.GetLength(0) - 1;

                /*  Stack to store elements and the count
                    of the numbers they popped

                    First part of pair will be the
                    value of inserted element.
                    Second part will be the count
                    of the number of elements pushed
                    before with a greater value */
                Stack<pair> stack = new Stack<pair>();

                // variable to store the number of
                // submatrices with all 1s
                int totalSubMatrices = 0;

                while (row >= 0)
                {
                    int c = 0;

                    while (stack.Count != 0 &&
                           stack.Peek().first > p_arr[row, col])
                    {
                        totalSubMatrices -= (stack.Peek().second + 1) *
                                  (stack.Peek().first - p_arr[row, col]);

                        c += stack.Peek().second + 1;
                        stack.Pop();
                    }

                    totalSubMatrices += p_arr[row, col];

                    totalMatrices += totalSubMatrices;

                    stack.Push(new pair(p_arr[row, col], c));

                    row--;
                }
            }
            return totalMatrices;
        }

        // Driver Code
        public static void Main(String[] args)
        {
            Boolean[,] arr = {{ true, true, false },
                      { true, false, true },
                      { false, true, true }};


            DisplayMatrix(arr);
            Console.WriteLine(matrixAllOne(arr));


            Console.Read();
        }



        private static void DisplayMatrix(Boolean[,] mat)
        {
            Console.WriteLine("############# INPUT MATRIX #################");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] ? "1" : "0");
                    Console.Write ("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        private static void DisplayMatrix(int[,] mat)
        {
            Console.WriteLine("############# PREFIX MATRIX #################");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
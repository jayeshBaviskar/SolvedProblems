using System;

namespace Matrix_Diagonal_items
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = new int[5,5];
            int counter = 1; 
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) ; j++)
                {
                    matrix[i, j] = counter;
                    ++counter;
                }
            }

            Print(matrix);
            Console.WriteLine("------------------------");
            PrintDiagonal(matrix);

        }

        static void PrintDiagonal(int[,] matrix)
        {
            int rowLen = matrix.GetLength(0);
            int colLen = matrix.GetLength(1);

            for (int col = 0; col < colLen ; col++)
            {
                Printleft(matrix, 0, col);
            } 

            for(int row = 1; row< rowLen; row++)
            {
                Printleft(matrix, row, colLen-1);
            }
             
        }

        static void Printleft(int[,] matrix, int row , int col)
        {
            while  ( (row < matrix.GetLength(0)) && (row>=0) && (col>=0) && (col<matrix.GetLength(1)))
            {
                Console.Write(matrix[row, col] + " ");
                --col;
                ++row;
            }
            Console.WriteLine("");
        }


        static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }

        }
    }
}

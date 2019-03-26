using System;
using System.Linq;

namespace _06._Queens_Puzzle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var matrix = new int[8][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[8];
            }

            PutQueens(matrix,0);
        }

        public static bool CanPlaceAQueen(int[][] matrix, int row, int col)
        {
            if (matrix[row][col] != 0)
            {
                return false;
            }

            if (matrix[row].Sum() != 0)
            {
                return false;
            }

            var columnContainsQueen = false;
            for (int i = 0; i < 8; i++)
            {
                if (matrix[i][col] != 0)
                {
                    columnContainsQueen = true;
                }
            }
            if (columnContainsQueen)
            {
                return false;
            }

            var firstDiagonalContainsQueen = false;
            var firstDiagonalRow = row;
            var firstDiagonalCol = col;
            while (firstDiagonalRow > 0 && firstDiagonalCol > 0)
            {
                firstDiagonalRow--;
                firstDiagonalCol--;
            }

            while (firstDiagonalRow < 8 && firstDiagonalCol < 8)
            {
                if (matrix[firstDiagonalRow][firstDiagonalCol] != 0)
                {
                    firstDiagonalContainsQueen = true;
                    break;
                }
                firstDiagonalRow++;
                firstDiagonalCol++;
            }

            if (firstDiagonalContainsQueen)
            {
                return false;
            }

            var secondDiagonalContainsQueens = false;
            var secondDiagonalRow = row;
            var secondDiagonalCol = col;
            while (secondDiagonalRow > 0 && secondDiagonalCol + 1 < 8)
            {
                secondDiagonalRow--;
                secondDiagonalCol++;
            }

            while (secondDiagonalRow < 8 && secondDiagonalCol >= 0)
            {
                if (matrix[secondDiagonalRow][secondDiagonalCol] != 0)
                {
                    secondDiagonalContainsQueens = true;
                    break;
                }

                secondDiagonalRow++;
                secondDiagonalCol--;
            }

            if (secondDiagonalContainsQueens)
            {
                return false;
            }

            return true;
        }

        public static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                    
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static void PutQueens(int[][] matrix ,int row)
        {
            if (row == 8)
            {
                PrintMatrix(matrix);
            }
            else
            {
                for (int col = 0; col < 8; col++)
                {
                    if (CanPlaceAQueen(matrix,row, col))
                    {
                        matrix[row][col] = 1;
                        PutQueens(matrix,row + 1);
                        matrix[row][col] = 0;
                    }
                }
            }
        }
    }
   
}

/*
 * Given a square matrix of N X N, rotate it by 90 in clockwise
 * direction without using any extra space
 */

using System.Globalization;

namespace Arrays
{
    internal class RotateMatrixNintyDeg
    {
        int[,] matrix =
        {
            { 1, 2, 3, 4
            },
            { 5, 6, 7, 8
            },
            { 9, 10, 11, 12
            },
            { 13, 14, 15, 16
            },
        };

        public int[,] RotateByNintyDeg()
        {
            int n = matrix.GetLength(0);

            // Transpose of matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }

            // Reverse the values
            for (int i = 0; i < n; i++)
            {
                for (int j = 0, k = n - 1; j < k; j++, k--)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }

            return matrix;
        }

        public void PrintMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

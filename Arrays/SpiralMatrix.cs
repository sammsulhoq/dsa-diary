/*
 * Given a matrix of N X M, the task is to print all the elements of the matrix in 
 * spiral order
 * 
 * Sample input:
 * 1 2 3 4
 * 5 6 7 8
 * 9 10 11 12
 * 13 14 15 16
 * 
 * Output:
 * 1 2 3 4 8 12 16 15 14 13 9 5 6 7 11 10
 * 
 * Analysis:
 * Input: The matrix is a 2D array of size N X M
 * Boundary variables: 
 *      top, bottom, left, right represents the limits of the untraversed section of the matrix
 *      - top: The first row boundary (initially 0)
 *      - bottom: The last row boundary (initially N - 1)
 *      - left: The first column boundary (initially 0)
 *      - right: Thr last column boundary (initially M - 1)
 * Traversal:
 *      Traverse the specified spiral direction by adjusting the boundaries after each pass:
 *          - Left to Right: Add all the elements in the top row and increment 'top' (as moving to +x dir)
 *          - Top to Bottom: Add all the element in the rightmost column and decrement 'right' (as moving to -y dir)
 *          - Right to Left: If rows remains, add all the elements in the bottom row and decrement 'bottom' (as moving to -x dir)
 *          - Bottom to Top: If column remains, add all the elements in the leftmost column and increment 'left' (as moving to +x dir)
 *          
 *      Traversal Loop:
 *          - Move 'left to right' across the 'top' boundary, then top++
 *          - Move 'top to bottom' along the 'right' boundary, then right--
 *          - If top <= bottom, move 'right to left' across the 'bottom' boundary, then bottom--
 *          - If left <= right, move 'bottom to right' across the 'left' boundary, then left++
 */
using System;
using System.Collections.Generic;


namespace Arrays
{
    internal class SpiralMatrix
    {
        int[,] matrix =
        {
            {1, 2, 3, 4 },
            {4, 5, 6, 7},
            {8, 9, 10, 11},
            {12, 13, 14, 15},
        };

        public List<int> Generate()
        {
            List<int> result = new List<int>();
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Define boundaries
            int top = 0, bottom = rows - 1;
            int left = 0, right = cols - 1;

            while (top <= bottom && left <= right)
            {
                // Traverse from left to right
                for (int i = left; i <= right; i++)
                {
                    result.Add(matrix[top, i]);
                }
                top++;

                // Traverse from top to bottom
                for (int i = top; i <= bottom; i++)
                {
                    result.Add(matrix[i, right]);
                }
                right--;

                // Traverse from right to left
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        result.Add(matrix[bottom, i]);
                    }
                    bottom--;
                }

                // Traverse from bottom to top
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        result.Add(matrix[i, left]);
                    }
                    left++;
                }
            }

            return result;
        }

        public void PrintMatrix(List<int> items)
        {
            Console.WriteLine(string.Join(",", items));
        }
    }
}

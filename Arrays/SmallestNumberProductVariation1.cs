/*
Given a positive number N, find the smallest number S such that the product of digits of S is equal to N.

Sample input:
N = 1000

Sample output:
5558

Solution:
0. Find the factor of digits and if it's prime then it's not possible
1. Least number of digits
2. Digits must be arranged in sorted order

Take an array of counters
0 0 0 3 0 0 1 2 <- counters
2 3 4 5 6 7 8 9 <- digits
 */

namespace Arrays
{
    internal class SmallestNumberProductVariation1
    {
        private int num = 1000;
        string result = "";

        public void Calculate()
        {
            for (int divisor = 9; divisor >= 2; divisor--)
            {
                while (num % divisor == 0)
                {
                    num /= divisor;
                    result += divisor.ToString();
                }
            }

            if (num != 1)
            {
                Console.WriteLine(-1);
            } else
            {
                Console.WriteLine(result);
            }
        }
    }
}

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
package arrays;

import java.util.Scanner;

public class SmallestNumberProductOne {
    public static void main(String[] args) {
        StringBuilder result = new StringBuilder();
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter an integer: ");
        int n = scanner.nextInt();

        for (int divisor = 9; divisor >= 2; divisor--) {
            while (n % divisor == 0) {
                n = n / divisor;
                result.insert(0, divisor);
            }
        }

        if (n != 1) {
            System.out.println(-1);
        } else {
            System.out.println(Integer.parseInt(result.toString()));
        }
    }
}

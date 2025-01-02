/*
Given an array of size N and an integer 'target'. Fina the indices(i, j)
of two numbers such that their sum is equal to target where i != j.
You can assume that there will be exactly one solution.

Sample input:
N = 6
arr = {11, 3, 7, 9, 14, 2}
target = 17

Sample output:
1 4
 */
package arrays;

import java.util.Arrays;
import java.util.HashMap;

public class TwoSum {
    public static void main(String[] args) {
        int[] arr = {11, 3, 7, 9, 14, 2};
        int target = 17;
        int[] result = new int[2];

        HashMap<Integer, Integer> map = new HashMap<>();
        for (int i = 0; i < arr.length; i++) {
            int second_number = target - arr[i];

            if (map.containsKey(second_number)) {
                result[0] = map.get(second_number);
                result[1] = i;
                break;
            }

            map.put(arr[i], i);
        }

        System.out.println(Arrays.toString(result));
    }
}

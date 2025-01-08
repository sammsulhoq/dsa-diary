/*
Given an array of size N and an integer 'target'. Find the indices(i, j)
of two numbers such that their sum is equal to target where i != j.
You can assume that there will be exactly one solution.

Sample input:
N = 6
arr = {11, 3, 7, 9, 14, 2}
target = 17

Sample output:
1 4
 */

using System.Collections;

namespace Arrays
{
    internal class TwoSum
    {
        int[] arr = { 11, 3, 7, 9, 14, 2 };
        int target = 17;
        int[] result = new int[2];

        Dictionary<int, int> map = new Dictionary<int, int>();

        public void Calculate()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int second_number = target - arr[i];

                if (map.ContainsKey(second_number))
                {
                    result[0] = map[second_number];
                    result[1] = i;
                    break;
                }

                map[arr[i]] = i;
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

/*
Given an array and a 'target', you need to find all the triplets (a[i], a[j], a[k])
such that a[i] + a[j] + a[k] = target and i != j != k. Note, solution must contain
unique triplets

Sample input:
N = 7
arr = {7, -6, 3, 8, -1, 8, -11}
target = 0

Sample output:
[-11, 3, 8], [-6, -1, 7]

Solution:
1. Sort the array
2. Use two pointer approach
 */

namespace Arrays
{
    internal class ThreeSum
    {
        int[] arr = { 7, -6, 3, 8, -1, 8, -11 };
        int target = 0;

        public void Calculate()
        {
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0 || (arr[i] != arr[i - 1]))
                {
                    int j = i + 1;
                    int k = arr.Length - 1;
                    int temp_target = target - arr[i];

                    while (j < k)
                    {
                        if (arr[j] + arr[k] == temp_target)
                        {
                            Console.WriteLine($"[{arr[i]},{arr[j]},{arr[k]}]");

                            while (j < k && arr[j] == arr[j + 1]) j++;
                            while (j < k && arr[k] == arr[k - 1]) k--;

                            j++;
                            k--;
                        } else if (arr[j] + arr[k] < temp_target)
                        {
                            j++;
                        } else
                        {
                            k--;
                        }
                    }
                }
            }
        }
    }
}

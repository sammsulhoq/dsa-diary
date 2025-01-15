/*
 * Given an array you need to find the majority element in the array.
 * Majority element is defined as the element which is appearing more 
 * than n/2 times in the array of length n.
 * Note - If there is no majority element, return -1
 * 
 * Sample input
 * N = 10
 * arr = { 2, 2, 6, 6, 6, 2, 2, 8, 2, 2 }
 * Sample output
 * 2
 */
using System.Collections.Generic;

namespace Arrays
{
    internal class MajorityElement
    {
        int[] arr = { 2, 2, 6, 6, 6, 2, 2, 8, 2, 2 };
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        public int Find()
        {
            int n = arr.Length;
            foreach (int num in arr)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                } else
                {
                    frequencyMap[num] = 1;
                }

                if (frequencyMap[num] > n/2)
                {
                    return num;
                }
            }
            return -1;
        }
    }
}

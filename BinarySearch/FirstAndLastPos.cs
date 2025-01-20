/*
 * Given a sorted array and a target, you need to find the first and the last position of that
 * target in the array. If the target is not present, then return -1.
 * 
 * Sample input:
 * N: 10
 * arr: {2, 3, 3, 4, 5, 5, 5, 5, 5, 8}
 * target: 5
 * 
 * output:
 * 4 8
 */

namespace BinarySearch
{
    internal class FirstAndLastPos
    {
        int[] arr = { 2, 3, 3, 4, 5, 5, 5, 5, 5, 8 };
        int target = 5;

        public void FindPosition()
        {
            int first = BinarySearch(arr, target, true);
            if (first == -1)
            {
                Console.WriteLine("-1 -1");
                return;
            }

            int last = BinarySearch(arr, target, false);
            Console.WriteLine($"{first.ToString()} {last.ToString()}");
        }

        private static int BinarySearch(int[] arr, int target, bool findFirst)
        {
            int start = 0, end = arr.Length - 1;
            int result = -1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] == target)
                {
                    result = mid;
                    if (findFirst)
                    {
                        end = mid - 1; // Search in the left half
                    }
                    else
                    {
                        start = mid + 1; // Search in the right half
                    }
                }
                else if (arr[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return result;
        }
    }
}

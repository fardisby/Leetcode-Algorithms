using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Algorithms.BinarySearch
{
    public class Solution
    {
        public int FindDuplicate(int[] nums)
        {
            int low = 1, high = nums.Length - 1;

            while (low < high)
            {
                int mid = low + (high - low) / 2;

                // Count how many numbers are less than or equal to mid
                int count = 0;
                foreach (int num in nums)
                {
                    if (num <= mid)
                        count++;
                }

                if (count > mid)
                {
                    // Duplicate is in the left half
                    high = mid;
                }
                else
                {
                    // Duplicate is in the right half
                    low = mid + 1;
                }
            }

            // Low and high converge to the duplicate number
            return low;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Algorithms.SlidingWindow
{
    public class MinimumSizeSubarraySum
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int left = 0, sum = 0, minLength = int.MaxValue;

            for (int right = 0; right < nums.Length; right++)
            {
                // Expand the window by adding nums[right]
                sum += nums[right];

                // Shrink the window as long as the condition is met
                while (sum >= target)
                {
                    // Update the minimum length
                    minLength = Math.Min(minLength, right - left +1);

                    // Shrink the window from the left
                    sum -= nums[left];
                    left++;
                }
            }

            // If no valid subarray was found, return 0
            return minLength == int.MaxValue ? 0 : minLength;

        }
    }
}

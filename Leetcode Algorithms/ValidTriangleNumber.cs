using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Algorithms
{
    public class ValidTriangleNumber
    {

        public int TrianleNumber(int[] nums)
        {
            Array.Sort(nums); //Step1: sort the array
            int count = 0;

            //Step 2:Loop through each position i as the largest side

            for (int i = nums.Length - 1; i >= 2; i--)
            {
                int left = 0;
                int right = i - 1;

                //step 3: Use two pointers to find valid pairs
                while (left < right)
                {
                    if (nums[left] + nums[right] > nums[i])
                    {
                        // Step4: If valid, count all pairs between left and right

                        count += right - left;
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }

            }
            return count;
        }
    }
}


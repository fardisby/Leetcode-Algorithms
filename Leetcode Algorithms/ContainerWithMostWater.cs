using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Algorithms
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxArea = 0;

            //Loop until two pointer meet

            while (left < right)
            {
                // Calculate the area formed by the lines at 'left' and 'right'

                int width = right - left;

                int h = Math.Min(height[left], height[right]);

                int area = width * h;

                // Update the maximum area if the current area is larger

                maxArea = Math.Max(maxArea, area);

                // Move the pointer pointing to the shorter line

                if (height[left] < height[right])
                {
                    left++; // Move the left pointer to the right
                }
                else
                {
                    {
                        right--; // Move the right pointer to the left
                    }
                }
               
            }

            return maxArea;  // Return the maximum area found
        }
    }
}

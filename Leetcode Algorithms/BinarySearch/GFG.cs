﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Algorithms.BinarySearch
{
    class GFG
    {

        // Returns index of x if it is present in
        // arr[low..high], else return -1
        static int binarySearch(int[] arr, int low, int high, int x)
        {
            if (high >= low)
            {
                int mid = low + (high - low) / 2;

                // If the element is present at the
                // middle itself
                if (arr[mid] == x)
                    return mid;

                // If element is smaller than mid, then
                // it can only be present in left subarray
                if (arr[mid] > x)
                    return binarySearch(arr, low, mid - 1, x);

                // Else the element can only be present
                // in right subarray
                return binarySearch(arr, mid + 1, high, x);
            }

            // We reach here when element is not present
            // in array
            return -1;
        }

        // Driver code
        public static void Main()
        {

            int[] arr = { 2, 3, 4, 10, 40 };
            int n = arr.Length;
            int x = 10;

            int result = binarySearch(arr, 0, n - 1, x);

            if (result == -1)
                Console.WriteLine(
                    "Element is not present in arrau");
            else
                Console.WriteLine("Element is present at index " + result);
        }
    }
}

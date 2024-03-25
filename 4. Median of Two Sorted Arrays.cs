using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    internal class _4
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] combinedArray = nums1.Concat(nums2).ToArray();
            Array.Sort(combinedArray);
            int lengthOfArray = combinedArray.Length;
            double medianValue;
            if (lengthOfArray % 2 == 0)
            {
                medianValue = combinedArray[lengthOfArray/2];
            }
            else
            {
                int lowerMedian = (int)lengthOfArray/2 - 0,5;
                int upperMedian = (int)lengthOfArray/2 + 0,5;
                medianValue = combinedArray[lowerMedian] + combinedArray[upperMedian];
            }
            return medianValue;
        }
    }
}

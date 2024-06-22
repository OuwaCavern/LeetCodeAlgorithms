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
            if (lengthOfArray % 2 == 1)
            {
                medianValue = combinedArray[lengthOfArray/2];
            }
            else
            {
                medianValue = (combinedArray[lengthOfArray/2] + combinedArray[(lengthOfArray/2 - 1)])/2.0;
            }
            return medianValue;
        }
    }
}

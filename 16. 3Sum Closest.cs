using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    internal class _16
    {
        // https://leetcode.com/problems/3sum-closest/
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int length = nums.Length;
            int result = nums[0] + nums[1] + nums[2];
            int theDifference = Math.Abs(target - result);

            for (int i = 0; i < length; i++)
            {
                int k = length - 1;
                int j = i + 1;

                while (j < k)
                {
                    int theSum = nums[i] + nums[j] + nums[k];
                    int newDifference = Math.Abs(target - theSum);
                    if (newDifference < theDifference)
                    {
                        result = theSum;
                        theDifference = newDifference;
                    }
                    if (theSum > target) k--;
                    else j++;
                }
            }

            return result;
        }
    }
}

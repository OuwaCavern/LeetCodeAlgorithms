using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    public class _3423
    {
        // https://leetcode.com/problems/maximum-difference-between-adjacent-elements-in-a-circular-array/description/
        public int MaxAdjacentDistance(int[] nums)
        {
            int highestDifference = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int difference = 0;
                if (i + 1 < nums.Length)
                {
                    difference = Math.Abs(nums[i] - nums[i + 1]);
                }
                else
                {
                    difference = Math.Abs(nums[0] - nums[nums.Length - 1]);
                }
                if (difference > highestDifference)
                {
                    highestDifference = difference;
                }
            }
            return highestDifference;
        }
    }
}

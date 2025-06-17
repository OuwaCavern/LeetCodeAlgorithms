using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    public class _2016
    {
        // https://leetcode.com/problems/maximum-difference-between-increasing-elements/description
        public int MaximumDifference(int[] nums)
        {
            int length = nums.Length;
            int currentMaxDifference = -1;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i > j) 
                        continue;
                    else if (nums[j] > nums[i] && (nums[j] - nums[i] > currentMaxDifference))
                    {
                        currentMaxDifference = nums[j] - nums[i];
                    }
                }
            }

            return currentMaxDifference;
        }
    }
}

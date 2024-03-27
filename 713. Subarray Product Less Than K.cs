using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    internal class _713
    {
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            List<List<int>> listOfValidSubarrays = new List<List<int>>();
            List<int> listOfValidNumbers = new List<int>();
            int totalNumberOfContigousSubarrays = (int)Math.Pow(2, nums.Length) - 1;
            int multiplicationResult = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                multiplicationResult = nums[i];
                for (int j = 0; j < nums.Length; j++) 
                {
                    if (i == j)
                    {
                        continue;
                    }
                    multiplicationResult = multiplicationResult * nums[j];
                    if (multiplicationResult < k)
                    {
                        listOfValidNumbers.Add(nums[j]);
                        List<int> listToAdd = new List<int>(listOfValidNumbers); 
                        listOfValidSubarrays.Add(listToAdd);
                    }
                }
            }
            listOfValidSubarrays.Distinct().ToList();
            return listOfValidSubarrays.Count;
        }
    }
}

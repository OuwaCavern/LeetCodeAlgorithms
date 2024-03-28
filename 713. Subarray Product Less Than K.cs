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
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                List<int> singles = new List<int>();
                if (i < k)
                {
                    singles.Add(nums[i]);
                    listOfValidSubarrays.Add((new List<int>(singles)));
                }
                int multiplicationResult = nums[i];
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
                        listOfValidNumbers = listOfValidNumbers.Distinct().ToList();
                        List<int> listToAdd = new List<int>(listOfValidNumbers); 
                        listOfValidSubarrays.Add(listToAdd);
                    }
                }
                singles.Clear();
            }
            for (int i=0; i < listOfValidSubarrays.Count; i++)
            {
                
            }
            return listOfValidSubarrays.Count;
        }
    }
}

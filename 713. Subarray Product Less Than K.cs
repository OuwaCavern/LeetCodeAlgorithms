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
            List<int> numsList = new List<int>();
            int multiplicationResult = 1;
            do
            {
                foreach (int i in numsList)
                {
                    multiplicationResult = multiplicationResult * i;
                }
                if (multiplicationResult < k)
                {
                    return (int)Math.Pow(2, numsList.Count);
                }
                else
                {
                    numsList.Remove(numsList.Min());
                }
            } while (multiplicationResult < k);
            return 0;
        }
    }
}

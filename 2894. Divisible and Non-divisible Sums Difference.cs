using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    public class _2894
    {
        // https://leetcode.com/problems/divisible-and-non-divisible-sums-difference/description/?envType=daily-question&envId=2025-05-27
        public int DifferenceOfSums(int n, int m)
        {
            int num1 = 0;
            int num2 = 0;

            while (n > 0)
            {
                if (n % m == 0)
                {
                    num2 += n;
                    n--;
                }
                else
                {
                    num1 += n;
                    n--;
                }
            }
            return num1 - num2;
        }
    }
}

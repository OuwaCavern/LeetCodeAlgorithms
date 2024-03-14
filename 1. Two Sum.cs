using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    internal class _1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int indexOfFirstNumber = 0;
            int indexOfSecondNumber = 0;
            foreach (int secondNum in nums)
            {
                foreach (int firstNum in nums)
                {
                    if (firstNum + secondNum == target)
                    {
                        if (firstNum == secondNum)
                        {
                            indexOfFirstNumber = Array.IndexOf(nums, firstNum);
                            indexOfSecondNumber = Array.IndexOf(nums, secondNum, indexOfFirstNumber + 1);
                            break;
                        }
                        else
                        {
                            indexOfFirstNumber = Array.IndexOf(nums, firstNum);
                            indexOfSecondNumber = Array.IndexOf(nums, secondNum);
                            goto AnswerFound;
                        }
                    }
                }
            }
            AnswerFound:
            return new int[] { indexOfFirstNumber, indexOfSecondNumber };
        }
    }
}

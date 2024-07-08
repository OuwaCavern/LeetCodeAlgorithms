using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    // https://leetcode.com/problems/4sum/
    internal class _18
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums.Length < 5)
            {
                return result;
            }


            IList<int> arrayToBeAdded = new List<int>();
            int theCurrentSum = 0;

            foreach (int num1 in nums)
            {
                int theFirstNumberToBeAdded = num1;
                int indexOfFirstNumberToBeAdded = Array.IndexOf(nums, theFirstNumberToBeAdded);
                int[] theArrayAfterFirstNumberIsRemoved = nums.Where((val, idx) => idx != indexOfFirstNumberToBeAdded).ToArray();
                foreach (int num2 in theArrayAfterFirstNumberIsRemoved)
                {
                    int theSecondNumberToBeAdded = num2;
                    int indexOfSecondNumberToBeAdded = Array.IndexOf(theArrayAfterFirstNumberIsRemoved, num2);
                    int[] theArrayAfterSecondNumberIsRemoved = theArrayAfterFirstNumberIsRemoved.Where((val, idx) => idx != indexOfSecondNumberToBeAdded).ToArray();
                    foreach (int num3 in theArrayAfterSecondNumberIsRemoved)
                    {
                        int theThirdNumberToBeAdded = num3;
                        int indexOfThirdNumberToBeAdded = Array.IndexOf(theArrayAfterSecondNumberIsRemoved, num3);
                        int[] theArrayAfterThirdNumberIsRemoved = theArrayAfterSecondNumberIsRemoved.Where((val, idx) => idx != indexOfThirdNumberToBeAdded).ToArray();
                        foreach (int num4 in theArrayAfterThirdNumberIsRemoved)
                        {
                            if (num1 + num2 + num3 + num4 == target)
                            {
                                arrayToBeAdded.Add(num1);
                                arrayToBeAdded.Add(num2);
                                arrayToBeAdded.Add(num3);
                                arrayToBeAdded.Add(num4);
                                result.Add(arrayToBeAdded);
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
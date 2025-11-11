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
            List<IList<int>> theResult = [];
            int[] originalNums = nums;
            for (int i = 0; i < nums.Length && nums.Length > 3; i++)
            {
                int numToBeAddedLast = originalNums[i];
                int threeSumResultShouldBe = target - originalNums[i];
                nums = originalNums.Skip(i + 1).ToArray();

                List<List<int>> results = ThreeSum(nums, threeSumResultShouldBe);

                if (results.Count > 0)
                {
                    foreach (var threeElementResult in results)
                    {
                        threeElementResult.Add(numToBeAddedLast);
                        if (theResult.Any(list => list.SequenceEqual(threeElementResult))) continue;
                        theResult.Add(threeElementResult);
                    }

                }
            }
            return theResult;
        }

        private List<List<int>> ThreeSum(int[] nums, int target)
        {
            List<List<int>> result = new List<List<int>>();
            Array.Sort(nums);
            int length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                int j = i + 1;
                int k = length - 1;
                while (j < k)
                {
                    if (nums[i] + nums[j] + nums[k] == target)
                    {
                        result.Add(new List<int> { nums[i], nums[j], nums[k] });
                        do
                        {
                            j++;
                        }
                        while (j < k && nums[j] == nums[j - 1]);

                        do
                        {
                            k--;
                        }
                        while (j < k && nums[k] == nums[k + 1]);
                    }
                    else if (nums[i] + nums[j] + nums[k] > target)
                        k--;
                    else
                        j++;
                }
            }

            return result;
        }
    }
}



/// What the hell is this
//IList<IList<int>> result = new List<IList<int>>();
//if (nums.Length < 5)
//{
//    return result;
//}

//bool check = true;


//foreach (int num1 in nums)
//{
//    int theFirstNumberToBeAdded = num1;
//    int indexOfFirstNumberToBeAdded = Array.IndexOf(nums, theFirstNumberToBeAdded);
//    int[] theArrayAfterFirstNumberIsRemoved = nums.Where((val, idx) => idx != indexOfFirstNumberToBeAdded).ToArray();
//    foreach (int num2 in theArrayAfterFirstNumberIsRemoved)
//    {
//        int theSecondNumberToBeAdded = num2;
//        int indexOfSecondNumberToBeAdded = Array.IndexOf(theArrayAfterFirstNumberIsRemoved, num2);
//        int[] theArrayAfterSecondNumberIsRemoved = theArrayAfterFirstNumberIsRemoved.Where((val, idx) => idx != indexOfSecondNumberToBeAdded).ToArray();
//        foreach (int num3 in theArrayAfterSecondNumberIsRemoved)
//        {
//            int theThirdNumberToBeAdded = num3;
//            int indexOfThirdNumberToBeAdded = Array.IndexOf(theArrayAfterSecondNumberIsRemoved, num3);
//            int[] theArrayAfterThirdNumberIsRemoved = theArrayAfterSecondNumberIsRemoved.Where((val, idx) => idx != indexOfThirdNumberToBeAdded).ToArray();
//            foreach (int num4 in theArrayAfterThirdNumberIsRemoved)
//            {
//                if (num1 + num2 + num3 + num4 == target)
//                {
//                    IList<int> arrayToBeAdded = new List<int>();
//                    arrayToBeAdded.Add(num1);
//                    arrayToBeAdded.Add(num2);
//                    arrayToBeAdded.Add(num3);
//                    arrayToBeAdded.Add(num4);
//                    if (check)
//                    {
//                        result.Add(arrayToBeAdded);
//                        check = false;
//                    }
//                    foreach (IList<int> array in result)
//                    {
//                        if (!(array.Contains(num1) && array.Contains(num2) && array.Contains(num3) && array.Contains(num4)))
//                        {
//                            result.Add(arrayToBeAdded);
//                        }
//                    }
//                }
//            }
//        }
//    }
//}
//return result;
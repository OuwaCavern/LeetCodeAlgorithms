using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    internal class _15
    {
        // https://leetcode.com/problems/3sum/description/
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);
            int length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                int j = i + 1;
                int k = length - 1;
                while (j < k)
                {
                    if (nums[i] + nums[j] == -nums[k])
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
                    else if (nums[i] + nums[j] + nums[k] > 0)
                        k--;
                    else
                        j++;
                }
            }

            return result;
        }
    }
}

            /// Fourth attempt (Time limit exceeeded)
            //List<IList<int>> result = new List<IList<int>>();
            //int length = nums.Length;

            //for (int i = 0; i < length; i++)
            //{
            //    for (int j = i + 1; j < length; j++)
            //    {
            //        for(int k = j + 1; k < length; k++)
            //        {
            //            if (nums[i] + nums[j] == -nums[k])
            //            {
            //                List<int> integersToBeAdded = new();
            //                integersToBeAdded.Add(nums[i]);
            //                integersToBeAdded.Add(nums[j]);
            //                integersToBeAdded.Add(nums[k]);
            //                if (!TripletAlreadyExists(result, integersToBeAdded)) result.Add(integersToBeAdded);
            //            }
            //        }
            //    }
            //}

            //return result;

            //static bool TripletAlreadyExists(List<IList<int>> triplets, IList<int> tripletToCompare)
            //{
            //    foreach (IList<int> triplet in triplets)
            //    {
            //        Dictionary<int, int> countOfOccurrences = new Dictionary<int, int>();
            //        foreach (int i in triplet)
            //        {
            //            if(countOfOccurrences.ContainsKey(i))
            //                countOfOccurrences[i]++;
            //            else
            //                countOfOccurrences.Add(i, 1);
            //        }
            //        foreach (int i in tripletToCompare)
            //        {
            //            if (countOfOccurrences.ContainsKey(i))
            //                countOfOccurrences[i]--;
            //            else
            //                break;
            //        }
            //        if (countOfOccurrences.Values.All(x => x == 0)) return true;
            //    }
            //    return false;
            //}
            // Third attempt
            //List<IList<int>> result = new List<IList<int>>();
            //int length = nums.Length;
            //for (int i = 0; i < length; i++)
            //{
            //    int leap = 1;
            //    for (int j = i + leap; j < length && j + leap < length; j += leap)
            //    {
            //        if (nums[i] + nums[j] == -nums[j + leap])
            //        {
            //            List<int> integersToBeAdded = new();
            //            integersToBeAdded.Add(nums[i]);
            //            integersToBeAdded.Add(nums[j]);
            //            integersToBeAdded.Add(nums[j + leap]);
            //            if(!TripletAlreadyExists(result, integersToBeAdded)) result.Add(integersToBeAdded);
            //        }
            //    }
            //}
            //return result;

            //static bool TripletAlreadyExists (List<IList<int>> triplets, IList<int> tripletToCompare)
            //{
            //    foreach(IList<int> triplet in triplets)
            //    {
            //        for(int i = 0; i < triplet.Count; i++)
            //        {
            //            if (!tripletToCompare.Contains(triplet[i])) break;
            //            else if (i == triplet.Count - 1) return true;
            //        }
            //    }
            //    return false;
            //}

            /// Second attempt
            //List<IList<int>> result = new List<IList<int>>();
            //int length = nums.Length;
            //int indexOfSecond = 1;
            //for (int i = 0; i + 1 < length; i++)
            //{
            //    indexOfSecond = i + 1;
            //    for (int j = 0; j < length; j++)
            //    {
            //        if (i != j && j != indexOfSecond && nums[i] + nums[indexOfSecond] == -nums[j])
            //        {
            //            List<int> integersToBeAdded = new();
            //            integersToBeAdded.Add(nums[i]);
            //            integersToBeAdded.Add(nums[indexOfSecond]);
            //            integersToBeAdded.Add(nums[j]);
            //            if(!TripletAlreadyExists(result, (IList<int>)integersToBeAdded)) result.Add((IList<int>)integersToBeAdded); 
            //        }
            //    }
            //}
            //return (IList<IList<int>>)result;

            //static bool TripletAlreadyExists (List<IList<int>> triplets, IList<int> tripletToCompare)
            //{
            //    foreach(IList<int> triplet in triplets)
            //    {
            //        for(int i = 0; i < triplet.Count; i++)
            //        {
            //            if (!tripletToCompare.Contains(triplet[i])) break;
            //            else if (i == triplet.Count - 1) return true;
            //        }
            //    }
            //    return false;
            //}



            /// First Attempt
            //List<IList<int>> result = new List<IList<int>>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = 0; j < nums.Length; j++)
            //    {
            //        if ((i +j < nums.Length) && nums[i] + nums[j] + nums[i + j] == 0)
            //        {
            //            result.Add((IList<int>)new List<int>(nums[i] + nums[j] + nums[i + j]));
            //        }
            //    }
            //}

            //return (IList < IList<int> >) result;

            //List<IList<int>> result = new List<IList<int>>();
            //int length = nums.Length;
            //int indexOfSecondNum = length - 1;
            //int indexOfFirstNum = 0;

            //for(int i = 0; i < length; i++)
            //{
            //    for(int j = (indexOfFirstNum + 1); j < length; j++)
            //    {
            //        if (nums[indexOfFirstNum] + nums[indexOfSecondNum] + nums[j] == 0)
            //        {
            //            List<int> integersToBeAdded = new();
            //            integersToBeAdded.Add(nums[indexOfFirstNum]);
            //            integersToBeAdded.Add(nums[indexOfSecondNum]);
            //            integersToBeAdded.Add(nums[j]);
            //            result.Add((IList<int>)integersToBeAdded);
            //        }
            //    }
            //    if(indexOfFirstNum < length) indexOfFirstNum++;
            //    if (indexOfSecondNum > 0) indexOfSecondNum--;
            //}
            //return (IList<IList<int>>)result;
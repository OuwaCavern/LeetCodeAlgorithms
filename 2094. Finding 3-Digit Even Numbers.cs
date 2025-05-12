using System.Collections.Generic;
using System.Linq;

namespace LeetCode_Algorithms
{
    public class _2094
    {
        // https://leetcode.com/problems/finding-3-digit-even-numbers/
        public int[] FindEvenNumbers(int[] digits)
        {
            List<int> allCombinations = new List<int>();
            int arrLength = digits.Length;

            for (int i = 0; i < arrLength; i++)
            {
                for (int j = 0; j < digits.Length; j++)
                {
                    for (int k = 0; k < digits.Length; k++)
                    {
                        if (i != j && i != k && j != k)
                        {
                            string newChallenger = digits[i].ToString() + digits[j].ToString() + digits[k].ToString();
                            if (int.TryParse(newChallenger, out int result))
                            {
                                if (result % 2 == 0 && result >= 100 && !allCombinations.Contains(result))
                                {
                                    allCombinations.Add(result);
                                }
                            }
                        }
                    }
                }
            }
            allCombinations.Sort();
            return allCombinations.ToArray();
        }
    }
}
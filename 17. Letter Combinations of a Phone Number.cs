using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    internal class _17
    {
        // https://leetcode.com/problems/letter-combinations-of-a-phone-number/description/
        public IList<string> LetterCombinations(string digits)
        {
            if (digits.Length == 0) return new List<string>();

            List<string> allCombinations = new List<string>();
            PhoneLettterConverter(digits[0], ref allCombinations); // base case

            for (int i = 1; i < digits.Length; i++)
            {
                List<string> listOfLettersToBeCombined = new List<string>();
                PhoneLettterConverter(digits[i], ref listOfLettersToBeCombined);
                int currentCombinations = allCombinations.Count;

                for (int j = 0; j < currentCombinations; j++)
                {
                    for(int k = 0; k < listOfLettersToBeCombined.Count; k++)
                    {
                        if (k + 1 == listOfLettersToBeCombined.Count)
                            allCombinations[j] += listOfLettersToBeCombined[k];
                        else
                            allCombinations.Add(allCombinations[j] + listOfLettersToBeCombined[k]);
                    }
                }
            }

            return allCombinations;
        }


        private void PhoneLettterConverter(int i, ref List<string> originalList)
        {
            if (i == '2') originalList.AddRange(["a", "b", "c"]);
            else if (i == '3') originalList.AddRange(["d", "e", "f"]);
            else if (i == '4') originalList.AddRange(["g", "h", "i"]);
            else if (i == '5') originalList.AddRange(["j", "k", "l"]);
            else if (i == '6') originalList.AddRange(["m", "n", "o"]);
            else if (i == '7') originalList.AddRange(["p", "q", "r", "s"]);
            else if (i == '8') originalList.AddRange(["t", "u", "v"]);
            else if (i == '9') originalList.AddRange(["w", "x", "y", "z"]);
        }
    }
}

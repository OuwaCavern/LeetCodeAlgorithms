using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    public class _3223
    {
        //https://leetcode.com/problems/minimum-length-of-string-after-operations/description/?envType=daily-question&envId=2025-01-13
        public int MinimumLength(string s)
        {
            int minimumLength = s.Length;
            Stack<char> charactersToBeAvoided = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!charactersToBeAvoided.Contains(s[i]))
                {
                    int numberOfOccurrences = s.Count(f => f == s[i]);

                    if (numberOfOccurrences >= 3)
                    {
                        charactersToBeAvoided.Push(s[i]);
                        if (numberOfOccurrences % 2 == 1)
                        {
                            minimumLength -= (numberOfOccurrences - 1);
                        }
                        else
                        {
                            minimumLength -= (numberOfOccurrences - 2);
                        }
                    }
                }
            }

            return minimumLength;
        }
    }
}

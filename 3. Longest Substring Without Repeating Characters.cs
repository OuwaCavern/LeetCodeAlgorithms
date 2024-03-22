using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    internal class _3
    {
        public int LengthOfLongestSubstring(string s)
        {
            int firstOccurrenceIndexOfDuplicate = 0;
            List<string> currentLongestString = new List<string>();
            List<string> topLongestString = new List<string>();
            for (int substr = 0; substr < s.Length; substr++)
            {
                string initialStr = s.Substring(substr, 1);
                if (!currentLongestString.Contains(initialStr))
                {
                    currentLongestString.Add(initialStr);
                    continue;
                }
                else
                {
                    firstOccurrenceIndexOfDuplicate = currentLongestString.IndexOf(initialStr);
                    if (topLongestString.Count < currentLongestString.Count)
                    {
                        topLongestString = new List<string>(currentLongestString);
                    }
                    currentLongestString.RemoveRange(0, firstOccurrenceIndexOfDuplicate+1);
                    currentLongestString.Add(initialStr);
                }
            }
            if (topLongestString.Count < currentLongestString.Count)
            {
                topLongestString = currentLongestString;
            }
            return topLongestString.Count;
        }
    }
}

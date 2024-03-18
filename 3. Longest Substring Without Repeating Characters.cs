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
            bool duplicateFound = false;
            List<string> currentLongestString = new List<string>();
            List<string> topLongestString = new List<string>();
            currentLongestString.Add(s.Substring(0, 1));
            for (int substr = 1; substr < s.Length -1; substr++)
            {
                string initialStr = s.Substring(substr, 1);
                string nextStr = s.Substring(substr + 1, 1);
                if (initialStr != nextStr & !currentLongestString.Contains(initialStr))
                {
                    currentLongestString.Add(initialStr);
                    continue;
                }
                else if (initialStr == nextStr & currentLongestString.Contains(initialStr))
                {
                    if (topLongestString.Count < currentLongestString.Count)
                    {
                        topLongestString = currentLongestString;
                    }
                    currentLongestString.Add(initialStr);
                }
            }
            return currentLongestString.Count;
        }

    }
}

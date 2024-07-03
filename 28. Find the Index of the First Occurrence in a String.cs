using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    internal class _28
    {
        public int StrStr(string haystack, string needle)
        {
            List<char> attemptedNeedle = new();
            int startIndex = -1;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (needle[i] == haystack[i] && attemptedNeedle.Count == 0)
                {
                    startIndex = i;
                    attemptedNeedle.Add(haystack[i]);
                }
                else if (needle[i] == haystack[i] && attemptedNeedle.Count != needle.Length)
                {
                    attemptedNeedle.Add(haystack[i]);
                }
                else
                {
                    break;
                }
            }
            return startIndex;
        }
    }
}

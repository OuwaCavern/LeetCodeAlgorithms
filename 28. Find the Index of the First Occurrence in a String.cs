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
            Stack<char> needleStackFull = new();
            Stack<char> hayStack = new();

            foreach (char c in needle)
            {
                needleStackFull.Push(c);
            }
            foreach (char c in haystack)
            {
                hayStack.Push(c);
            }

            Stack<char> needleStack = new(needleStackFull);

            foreach(char c in haystack)
            {
                if (needleStack.Count > 0 && needleStack.Peek() == hayStack.Peek())
                {
                    needleStack.Pop();
                }
                else if (needleStack.Count != 0)
                {
                    needleStack = new(needleStackFull);
                }
                else
                {
                    return true;
                }
                hayStack.Pop();
            }
        }
    }
}

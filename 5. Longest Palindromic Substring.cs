using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    public class _5
    {
        internal string LongestPalindrome(string s)
        {
            List<List<char>> longestPalindromeCollection = new();
            List<char> longestPalindrome = new();
            List<char> currentLongestPalindrome = new();
            foreach (char c in s)
            {
                longestPalindromeCollection.Add(c);
                List<char> longestPalindromeCollectionReversed = ReturnLongestPalindromeReversed(longestPalindrome);
                if (longestPalindromeCollection == longestPalindromeCollectionReversed)
                {
                    currentLongestPalindrome = longestPalindrome;
                }
                else
                {
                    longestPalindromeCollection.Add(currentLongestPalindrome);
                    longestPalindromeCollection.RemoveAt(0);
                }
            }
        }

        public List<char> ReturnLongestPalindromeReversed(List<char> longestPalindrome)
        {
            longestPalindrome.Reverse();
            return longestPalindrome;
        }
    }
}

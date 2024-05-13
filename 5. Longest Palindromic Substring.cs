using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    public class _5
    {
        public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        internal string LongestPalindrome(string s)
        {
            // My second attempt

            List<string> longPalindromes = new List<string>();
            List<string> substringsOfTheWord = new List<string>();
            if (s.Length == 1)
            {
                longPalindromes.Add(s);
            }
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 1; j <= j + 1 - i && j < s.Length; j++)
                {
                    substringsOfTheWord.Add(s.Substring(i, j));
                }
            }
            foreach (string substring in substringsOfTheWord)
            {
                if (substring.Length > 1)
                {
                    string reversedSubstring = Reverse(substring);
                    if (substring == reversedSubstring)
                    {
                        longPalindromes.Add(substring);
                    }
                }
            }
            Dictionary<string, int> theLongestPalindromeFinder = new();
            foreach (string palindrome in longPalindromes)
            {
                theLongestPalindromeFinder.Add(palindrome, palindrome.Count());
            }
            string theLongestPalindrome = theLongestPalindromeFinder.OrderByDescending(x => x.Value).First().Key;
            return theLongestPalindrome.ToString();



            // My first attempt

            //List<List<char>> longestPalindromeCollection = new();
            //List<char> longestPalindrome = new();
            //foreach (char c in s)
            //{
            //    longestPalindrome.Add(c);
            //    List<char> longestPalindromeReversed = new(longestPalindrome);
            //    longestPalindromeReversed.Reverse();
            //    string longestPalindromeString = string.Join("", longestPalindrome);
            //    string longestPalindromeReversedString = string.Join("", longestPalindromeReversed);
            //    if (longestPalindromeString == longestPalindromeReversedString)
            //    {
            //        longestPalindromeCollection.Add(longestPalindrome);
            //    }
            //    else
            //    {
            //        longestPalindromeCollection.Add(longestPalindrome);
            //        longestPalindrome.RemoveAt(0);
            //    }
            //}
            //Dictionary<List<char>, int> theLongestPalindromeFinder = new();
            //foreach (List<char> palindrome in longestPalindromeCollection)
            //{
            //    theLongestPalindromeFinder.Add(palindrome, palindrome.Count());
            //}
            //List<char> theLongestPalindrome = theLongestPalindromeFinder.OrderByDescending(x => x.Value).First().Key;
            //return theLongestPalindrome.ToString();
        }
    }
}

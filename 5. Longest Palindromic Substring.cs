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
            int lengthOfTheString = s.Length;
            substringsOfTheWord.Add(s);
            if (s.Length == 1)
            {
                longPalindromes.Add(s);
            }
            for (int i = 0; i < lengthOfTheString; i++)
            {
                for (int j = 1; j <= lengthOfTheString - i && j < lengthOfTheString; j++)
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
                else
                {
                    longPalindromes.Add(substring);
                }
            }
            string theLongestPalindrome = longPalindromes.MaxBy(s => s.Length);
            return theLongestPalindrome;


            // inefficient code in terms of time complexity

            //dictionary<string, int> thelongestpalindromefinder = new();
            //foreach (string palindrome in longpalindromes)
            //{
            //    if (thelongestpalindromefinder.containskey(palindrome))
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        thelongestpalindromefinder.add(palindrome, palindrome.count());
            //    }
            //}
            //string thelongestpalindrome = thelongestpalindromefinder.orderbydescending(x => x.value).first().key;


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

using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
            Stack<char> frontStack = new();
            Stack<char> backStack = new();
            Stack<char> theLongestPalindrome = new();

            for (int i = 0; i < s.Length; i++)
            {
                frontStack.Push(s[i]);
                backStack.Push(s[s.Length - i]);
            }

            foreach (char c in frontStack)
            {
                if (frontStack.Peek() == backStack.Peek())
                {
                    theLongestPalindrome.Push(frontStack.Peek());
                } 
            }

            return "notFound";




            // My third attempt

            //List<string> longPalindromes = new List<string>();
            //List<string> substringsOfTheWord = new List<string>();
            //int lengthOfLongestPalindrome = 0;
            //int lengthOfTheString = s.Length;
            //if (lengthOfTheString == 1)
            //{
            //    longPalindromes.Add(s);
            //}
            //for (int i = 0; i < lengthOfTheString && i >= lengthOfLongestPalindrome; i++)
            //{
            //    for (int j = 1; j <= lengthOfTheString - i && j < lengthOfTheString && i + j >= lengthOfLongestPalindrome; j++)
            //    {
            //        string substring = s.Substring(i, j);
            //        string reversedSubstring = Reverse(substring);
            //        if (substring == reversedSubstring)
            //        {
            //            longPalindromes.Add(substring);
            //            if (i + j < lengthOfTheString && (substring.Length %2 == 1 && substring.First() == s.Substring(i, j+1).Last() || (substring.Length >= 2 && substring.Substring(1,1).Contains(s.Substring(i, j + 1).Last()))))
            //            {
            //                longPalindromes.Add(s.Substring(i, j+1));
            //            }
            //            lengthOfLongestPalindrome = substring.Length;
            //        }
            //    }
            //}
            //string theLongestPalindrome = longPalindromes.MaxBy(s => s.Length);
            //return theLongestPalindrome;



            // My second attempt

            //List<string> longPalindromes = new List<string>();
            //List<string> substringsOfTheWord = new List<string>();
            //int lengthOfTheString = s.Length;
            //substringsOfTheWord.Add(s);
            //if (s.Length == 1)
            //{
            //    longPalindromes.Add(s);
            //}
            //for (int i = 0; i < lengthOfTheString; i++)
            //{
            //    for (int j = 1; j <= lengthOfTheString - i && j < lengthOfTheString; j++)
            //    {
            //        substringsOfTheWord.Add(s.Substring(i, j));
            //    }
            //}
            //foreach (string substring in substringsOfTheWord)
            //{
            //    if (substring.Length > 1)
            //    {
            //        string reversedSubstring = Reverse(substring);
            //        if (substring == reversedSubstring)
            //        {
            //            longPalindromes.Add(substring);
            //        }
            //    }
            //    else
            //    {
            //        longPalindromes.Add(substring);
            //    }
            //}
            //string theLongestPalindrome = longPalindromes.MaxBy(s => s.Length);
            //return theLongestPalindrome;


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

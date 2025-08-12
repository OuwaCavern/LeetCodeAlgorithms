using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    public class _10
    {
        // https://leetcode.com/problems/regular-expression-matching/description/
        public bool IsMatch(string s, string p)
        {
            /// First Attempt(Where I thought that pattern should exactly match with the input(e.g. for abcd, a.* cd works but da.* cd does not))
            
            // base case that does not include the wildcards and does a simple check
            if (s == p || p == ".*")
                return true;
            else if (!p.Contains('*') && !p.Contains('.'))
                return false;



            bool jokerCombinationRemovedFromStart = false;
            bool jokerCombinationRemovedFromEnd = false;

            Dictionary<int, int> allJokerCombinations = FindAllTheJokerCombinations(p);
            // if the joker combination .* is at the start, we only have to check the last characters up until the star
            if (allJokerCombinations.ContainsKey(0))
            {
                p = p.Substring(2);
                allJokerCombinations.Remove(0);
                jokerCombinationRemovedFromStart = true;
            }
            if (allJokerCombinations.ContainsKey(p.Length - 2))
            {
                p = p.Substring(0, p.Length - 3);
                allJokerCombinations.Remove(p.Length - 2);
                jokerCombinationRemovedFromEnd = true;
            }
            if (allJokerCombinations.Any())
            {
                foreach (KeyValuePair<int, int> jokerCombination in allJokerCombinations)
                {
                    p = p.Substring(0, jokerCombination.Key) + p.Substring(jokerCombination.Value + 1);
                }
            }



            UInt16 indexOfString = 0;
            UInt16 matchedCharacterCount = 0;

            if (jokerCombinationRemovedFromStart)
            {
                s = Reverse(s);
                p = Reverse(p);
            }

            for (UInt16 i = 0; i < p.Length; i++)
            {
                if (indexOfString < s.Length && (s[indexOfString] == p[i] || p[i] == '.'))
                {
                    matchedCharacterCount++;
                    indexOfString++;
                }
                else if (indexOfString < s.Length && (p[i] == '*' && p[i - 1] == s[indexOfString]))
                {
                    char repeatingChar = p[i - 1];
                    bool repeating = true;
                    while (repeating)
                    {
                        matchedCharacterCount++;
                        if (indexOfString + 1 < s.Length) indexOfString++;

                        if (repeatingChar != s[indexOfString])
                        {
                            repeating = false;
                        }
                    }
                }
                else if ((i + 1 < p.Length && p[i + 1] == '*') || p[i] == '*')
                {
                    matchedCharacterCount++;
                    continue;
                }
                else
                {
                    indexOfString = 0;
                    matchedCharacterCount = 0;
                }
            }

            return matchedCharacterCount >= p.Length;

            // Finds all combinations in a string with .* meaning that any character can be repeated infinite times.
            static Dictionary<int, int> FindAllTheJokerCombinations(string p)
            {
                Dictionary<int, int> jokerCombinations = new();

                for (int i = 0; i < p.Length; i++)
                {
                    if (p[i] == '.' && i + 1 != p.Length && p[i + 1] == '*')
                        jokerCombinations.Add(i, i + 1);
                }

                return jokerCombinations;
            }
            static string Reverse(string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
        /// Second Attempt

        //// base case that does not include the wildcards and does a simple check
        //if (s == p || FindAllTheJokerCombinations(p).Any())
        //    return true;
        //else if (!p.Contains('*') && !p.Contains('.'))
        //    return false;


        //UInt16 indexOfString = 0;
        //for (UInt16 i = 0; i < p.Length; i ++)
        //{
        //    if (indexOfString < s.Length && (s[indexOfString] == p[i] || p[i] == '.'))
        //    {
        //        indexOfString++;
        //        if (indexOfString >= s.Length - 1) return true;
        //    }
        //    else if (p[i] == '*' && p[i - 1] == s[indexOfString])
        //    {
        //        char repeatingChar = p[i - 1];
        //        bool repeating = true;
        //        while (repeating)
        //        {
        //            if (repeatingChar != s[indexOfString])
        //            {
        //                repeating = false;
        //            }
        //            else
        //            {
        //                indexOfString++;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        indexOfString = 0;
        //    }
        //}

        //return indexOfString >= s.Length - 1;

        //// Finds all combinations in a string with .* meaning that any character can be repeated infinite times.
        //static Dictionary<int, int> FindAllTheJokerCombinations(string p)
        //{
        //    Dictionary<int, int> jokerCombinations = new();

        //    for (int i = 0; i < p.Length; i++)
        //    {
        //        if (p[i] == '.' && i + 1 != p.Length && p[i + 1] == '*')
        //            jokerCombinations.Add(i, i + 1);
        //    }

        //    return jokerCombinations;
        //}

    }
    }
}

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

            /// First Attempt(Where I thought that pattern should exactly match with the input(e.g. for abcd, a.* cd works but da.* cd does not))

            Dictionary<int, int> allJokerCombinations = FindAllTheJokerCombinations(p);
            // if the joker combination .* is at the start, we only have to check the last characters up until the star
            if (allJokerCombinations.ContainsKey(0))
            {
                p = p.Substring(2);
                s = s.Substring(s.Length - p.Length, p.Length);
                allJokerCombinations.Remove(0);
            }
            if (allJokerCombinations.ContainsKey(p.Length - 2))
            {
                p = p.Substring(0, p.Length - 3);
                s = s.Substring(0, p.Length - 1);
                allJokerCombinations.Remove(p.Length - 2);
            }
            if (allJokerCombinations.Any())
            {
                foreach (KeyValuePair<int, int> jokerCombination in allJokerCombinations)
                {
                    s = s.Substring(0, jokerCombination.Key) + s.Substring(s.Length - (p.Length - jokerCombination.Value));
                    p = p.Substring(0, jokerCombination.Key) + p.Substring(jokerCombination.Value + 1);
                }
            }

            // base case that does not include the wildcards and does a simple check
            if (s == p)
                return true;
            else if (!p.Contains('*') && !p.Contains('.'))
                return false;




            UInt16 indexOfString = 0;
            UInt16 matchedCharacters = 0;
            for (UInt16 i = 0; i < p.Length; i++)
            {
                if (indexOfString < s.Length && (s[indexOfString] == p[i] || p[i] == '.'))
                {
                    indexOfString++;
                    matchedCharacters++;
                }
                else if (indexOfString < s.Length && (p[i] == '*' && p[i - 1] == s[indexOfString]))
                {
                    char repeatingChar = p[i - 1];
                    bool repeating = true;
                    while (repeating)
                    {
                        if (repeatingChar != s[indexOfString])
                        {
                            repeating = false;
                        }
                        else if (indexOfString < s.Length - 1)
                        {
                            indexOfString++;
                            matchedCharacters++;
                        }
                        else
                        {
                            matchedCharacters++;
                            repeating = false;
                        }
                    }
                }
                else if ((i + 1 < p.Length && p[i + 1] == '*') || p[i] == '*')
                {
                    continue;
                }
                else
                {
                    indexOfString = 0;
                    matchedCharacters = 0;
                }
            }

            return matchedCharacters >= s.Length;

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
        }
    }
}

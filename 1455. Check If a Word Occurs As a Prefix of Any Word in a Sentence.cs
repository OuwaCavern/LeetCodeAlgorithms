using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    internal class _1455
    {
        //https://leetcode.com/problems/check-if-a-word-occurs-as-a-prefix-of-any-word-in-a-sentence/
        internal int IsPrefixOfWord(string sentence, string searchWord)
        {
            string[] wordsOfTheSentence = sentence.Split(" ");

            int whichWord = 0;

            foreach (string word in wordsOfTheSentence)
            {
                whichWord++;

                if (word.IndexOf(searchWord) == 0)
                {
                    return whichWord;
                }
            }
            return -1;
        }
    }
}

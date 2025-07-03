using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    internal class _3304
    {
        public char KthCharacter(int k)
        {
            StringBuilder word = new StringBuilder("a");

            while (word.Length < k)
            {
                char[] characters = word.ToString().ToCharArray();
                List<int> asciiValuesOfCharactersToBeAdded = new List<int>();

                for (int i = 0; i < characters.Length; i++)
                {
                    word.Append(Convert.ToChar(characters[i] + 1));
                }
            }

            return word.ToString()[k - 1];
        }
    }
}

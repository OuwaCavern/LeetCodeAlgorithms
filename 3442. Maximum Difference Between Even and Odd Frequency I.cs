using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    public class _3442
    {
        // https://leetcode.com/problems/maximum-difference-between-even-and-odd-frequency-i/description/
        public int MaxDifference(string s)
        {
            Dictionary<char, int> charactersAndTheirFrequencies = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (charactersAndTheirFrequencies.ContainsKey(c))
                {
                    charactersAndTheirFrequencies[c]++;
                }
                else
                {
                    charactersAndTheirFrequencies.Add(c, 1);
                }
            }

            int oddNumber = (from freq in charactersAndTheirFrequencies
                             where freq.Value % 2 == 1
                             select freq.Value).Max();
            
            int evenNumber = (from freq in charactersAndTheirFrequencies
                             where freq.Value % 2 == 0
                             select freq.Value).Min();

            return oddNumber - evenNumber;
        }
    }
}

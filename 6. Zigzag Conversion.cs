using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    public class _6
    {
        public string Convert(string s, int numRows)
        {
            StringBuilder sb = new StringBuilder();

            int upperRowCharacterLocatorCount = 1;
            int maximumNumberOfUpperRowElements = 0;
            if (s.Length <= (upperRowCharacterLocatorCount + (numRows - 1)))
            {
                maximumNumberOfUpperRowElements++;
                upperRowCharacterLocatorCount += (upperRowCharacterLocatorCount + (2 * (numRows - 1)));
            }
            int lowerRowCharacterLocatorCount = numRows;
            int maximumNumberOfLowerRowElements = 0;
            if (s.Length <= (lowerRowCharacterLocatorCount + (numRows - 1)))
            {
                maximumNumberOfLowerRowElements++;
                lowerRowCharacterLocatorCount += (lowerRowCharacterLocatorCount + (2 * (numRows - 1)));
            }

            int baseLeap = (2 * (numRows - 1));
            
            for (int i = 0; i <= numRows; i++)
            {
                // If it is first or last row of the zigzag pattern, another rule applies
                if (i == 0)
                {
                    for (int j = 0; j < maximumNumberOfUpperRowElements; j++)
                    {
                        sb.Append(s[i + j * baseLeap]);
                    }
                }
                else if (i == numRows - 1)
                {
                    for (int j = 0; j < maximumNumberOfLowerRowElements; j++)
                    {
                        sb.Append(s[i + j * baseLeap]);
                    }
                }
                else
                {
                    int countOfRowElements = 0;
                    if (i + countOfRowElements * baseLeap < s.Length)
                    {
                        sb.Append(s[i + countOfRowElements * baseLeap]);
                        countOfRowElements++;
                    }

                }
            }
            return sb.ToString();
        }
    }
}

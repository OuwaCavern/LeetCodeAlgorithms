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
            int length = s.Length;

            if (numRows == 1)
            {
                return s;
            }

            int leapNumber = 2 * (numRows - 1);
            StringBuilder finalWord = new StringBuilder();

            for (int i = 0; i < numRows; i++)
            {
                if (i == 0 || (i == (numRows - 1)))
                {
                    for (int j = i; j < length; j += leapNumber)
                    {
                        finalWord.Append(s[j]);
                    }
                }
                else
                {
                    bool oscillate = false;
                    for (int j = i; j < length; j += 0)
                    {
                        finalWord.Append(s[j]);
                        if (oscillate)
                        {
                            j += i * 2;
                            oscillate = false;
                        }
                        else
                        {
                            j += (leapNumber - i * 2);
                            oscillate = true;
                        }
                    }
                }

            }

            return finalWord.ToString();


            /// Incomplete first attempt
            
            //StringBuilder sb = new StringBuilder();

            //int upperRowCharacterLocatorCount = 1;
            //int maximumNumberOfUpperRowElements = 0;
            //if (s.Length <= (upperRowCharacterLocatorCount + (numRows - 1)))
            //{
            //    maximumNumberOfUpperRowElements++;
            //    upperRowCharacterLocatorCount += (upperRowCharacterLocatorCount + (2 * (numRows - 1)));
            //}
            //int lowerRowCharacterLocatorCount = numRows;
            //int maximumNumberOfLowerRowElements = 0;
            //if (s.Length <= (lowerRowCharacterLocatorCount + (numRows - 1)))
            //{
            //    maximumNumberOfLowerRowElements++;
            //    lowerRowCharacterLocatorCount += (lowerRowCharacterLocatorCount + (2 * (numRows - 1)));
            //}

            //int baseLeap = (2 * (numRows - 1));
            
            //for (int i = 0; i <= numRows; i++)
            //{
            //    // If it is first or last row of the zigzag pattern, another rule applies
            //    if (i == 0)
            //    {
            //        for (int j = 0; j < maximumNumberOfUpperRowElements; j++)
            //        {
            //            sb.Append(s[i + j * baseLeap]);
            //        }
            //    }
            //    else if (i == numRows - 1)
            //    {
            //        for (int j = 0; j < maximumNumberOfLowerRowElements; j++)
            //        {
            //            sb.Append(s[i + j * baseLeap]);
            //        }
            //    }
            //    else
            //    {
            //        int countOfRowElements = 0;
            //        if (i + countOfRowElements * baseLeap < s.Length)
            //        {
            //            sb.Append(s[i + countOfRowElements * baseLeap]);
            //            countOfRowElements++;
            //        }

            //    }
            //}
            //return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    internal class _2264
    {
        public string LargestGoodInteger(string num)
        {
            string currentHighestInteger = string.Empty;
            int length = num.Length;
            for (int i = 0; i + 2 < length; i++)
            {
                char firstNumber = num[i];
                char secondNumber = num[i + 1];
                char thirdNumber = num[i + 2];

                if (!(firstNumber == secondNumber && secondNumber == thirdNumber))
                    continue;

                int currentHighestIntConverted = 0;
                if (currentHighestInteger != string.Empty)
                {
                    currentHighestIntConverted = int.Parse(currentHighestInteger);
                }

                string highestIntegerCandidate = firstNumber.ToString() + secondNumber.ToString() + thirdNumber.ToString();

                if (currentHighestInteger == string.Empty || currentHighestIntConverted < int.Parse(highestIntegerCandidate))
                {
                    currentHighestInteger = highestIntegerCandidate.ToString();
                }
            }

            return currentHighestInteger;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    internal class _8
    {
        public int MyAtoi(string s)
        {
            // Initialize the array of digits
            char[] digitsArray = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
            // L-trim the string
            s = s.TrimStart();
            // Determine if the leftmost character is + or -, if it is a digit, assume +
            bool isPositive = true;
            bool signFound = false;
            List<int> theIntegerToBeReturned = new();
            for (int i = 0; i < s.Length; i++)
            {
                if (digitsArray.Contains(s[i]))
                {
                    // - '0' part is for retrieving the integer value instead of ASCII value
                    theIntegerToBeReturned.Add(s[i] - '0');
                    signFound = true;
                }
                else if (i == 0 && s[i] == '-' && signFound == false)
                {
                    isPositive = false;
                }
                else if (i == 0 && s[i] == '+' && signFound == false)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            string theIntegerString = string.Join("", theIntegerToBeReturned);
            theIntegerString = isPositive ? theIntegerString : '-' + theIntegerString;
            if (string.IsNullOrEmpty(theIntegerString) || theIntegerString == "-")
            {
                return 0;
            }
            else
            {
                Int32 theIntegerInt128;
                // If the result is greater than Math.Pow(2, 31) - 1,return Math.Pow(2, 31) - 1. If the result is less than Math.Pow(-2, 31), return Math.Pow(-2, 31)
                if (!Int32.TryParse(theIntegerString,out theIntegerInt128))
                {
                    if (isPositive)
                    {
                        return Int32.MaxValue;
                    }
                    else
                    {
                        return Int32.MinValue;
                    }
                }
                else
                {
                    return theIntegerInt128;
                }
            }
        }
    }
}

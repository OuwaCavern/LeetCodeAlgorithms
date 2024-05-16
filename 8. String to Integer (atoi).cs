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
            s.TrimStart();
            // Determine if the leftmost character is + or -, if it is a digit, assume +
            bool isPositive = true;
            bool signFound = false;
            List<int> theIntegerToBeReturned = new();
            for (int i = 0; i < s.Length; i++)
            {
                if (digitsArray.Contains(s[i]))
                {
                    theIntegerToBeReturned.Add(i);
                    signFound = true;
                }
                else if (i == 1 && s[i] == '-' && signFound == false)
                {
                    isPositive = false;
                }
                else
                {
                    break;
                }
            }
            string theIntegerString = theIntegerToBeReturned.ToString();
            theIntegerString = isPositive ? theIntegerString : '-' + theIntegerString;
            Int128 theIntegerInt128 = Int128.Parse(theIntegerString);
            // Determine if next character(s) are digits, whenever there is not a digit, stop the function to read the string and return the integer formed by reading digits up to that point, if there were no digits up until that point, return 0

            // If the result is greater than Math.Pow(2, 31) - 1,return Math.Pow(2, 31) - 1. If the result is less than Math.Pow(-2, 31), return Math.Pow(-2, 31)
            if (theIntegerInt128 > Int32.MaxValue)
            {
                theIntegerInt128 = Int32.MaxValue;
            }
            else if (theIntegerInt128 < Int32.MinValue)
            {
                theIntegerInt128 = Int32.MinValue;
            }
            return (int)theIntegerInt128;
        }
    }
}

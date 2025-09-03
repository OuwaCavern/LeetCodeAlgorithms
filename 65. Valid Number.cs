using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    internal class _65
    {
        // https://leetcode.com/problems/valid-number/
        public bool IsNumber(string s)
        {
            int stringLength = s.Length;
            char[] digits = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
            char[] exponent = ['e', 'E'];
            char[] signs = ['-', '+'];
            const char dot = '.';

            bool exponentFound = false;

            for (int i = 0; i < stringLength; i++)
            {
                // Digit case
                if (digits.Contains(s[i]))
                    continue;

                // Exponent case
                if (exponent.Contains(s[i]) 
                    && 
                        (
                            ((i > 0 && digits.Contains(s[i - 1])) && (i + 1 < stringLength && digits.Contains(s[i + 1]))) // There is a number before and after the exponent
                            || ((i > 0 && digits.Contains(s[i - 1])) && (i + 1 < stringLength && signs.Contains(s[i + 1]))) // There is a number before the exponent and a sign after the exponent 
                        )
                    )
                        {
                            exponentFound = true;
                            continue;
                        }

                // Dot case
                if (s[i] == dot && i == 0 && i + 1 < stringLength && digits.Contains(s[i + 1]) || s[i] == dot && !exponentFound
                    &&
                        (
                            ((i > 0 && digits.Contains(s[i - 1])) && (i + 1 < stringLength && (digits.Contains(s[i + 1]) || exponent.Contains(s[i + 1])))) // There is a number before the dot and after the dot, there is either a number or exponent
                            || (( i > 0 && signs.Contains((s[i - 1])) && (i < stringLength && (digits.Contains(s[i + 1]) || exponent.Contains(s[i + 1]))))) // There is a number or sign before the dot and after the dot, there is either a number of exponent
                        )
                    )
                {
                    continue;
                }

                // Sign case
                if (signs.Contains(s[i])
                    &&
                        (
                            ((i == 0) && (i + 1 < stringLength && (digits.Contains(s[i + 1])))) // Sign is at the start and right after, there is a number
                            || ((i > 0 && exponent.Contains((s[i - 1])))) // If sign appears anywhere but the start, there should be an exponent right before it.
                        )
                    )
                    continue;

                return false;
            }

            return true;
        }
    }
}

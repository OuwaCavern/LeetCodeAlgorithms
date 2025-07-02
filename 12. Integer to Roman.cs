using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    // https://leetcode.com/problems/integer-to-roman/description/
    public class _12
    {
        public string IntToRoman(int num)
        {
            char[] digits = num.ToString().ToCharArray();
            string resultingRomanNumber = String.Empty;

            for (int i = 0; i < digits.Length; i++)
            {
                resultingRomanNumber += AddTheRomanLetterBasedOnPlaceOfDigit(i, int.Parse(digits[i].ToString()), digits.Length);
            }

            return resultingRomanNumber;
        }

        private static string AddTheRomanLetterBasedOnPlaceOfDigit(int index, int digit, int length)
        {
            if (digit == 4)
            {
                if (length - index == 3)
                {
                    return "CD";
                }
                else if (length - index == 2)
                {
                    return "XL";
                }
                else if (length - index == 1)
                {
                    return "IV";
                }
            }
            else if (digit == 9)
            {
                if (length - index == 3)
                {
                    return "CM";
                }
                else if (length - index == 2)
                {
                    return "XC";
                }
                else if (length - index == 1)
                {
                    return "IX";
                }
            }
            else
            {
                switch (digit)
                {
                    case 1:
                        if (length - index == 4) return "M";
                        if (length - index == 3) return "C";
                        if (length - index == 2) return "X";
                        if (length - index == 1) return "I";
                        break;
                    case 2:
                        if (length - index == 4) return "MM";
                        if (length - index == 3) return "CC";
                        if (length - index == 2) return "XX";
                        if (length - index == 1) return "II";
                        break;
                    case 3:
                        if (length - index == 4) return "MMM";
                        if (length - index == 3) return "CCC";
                        if (length - index == 2) return "XXX";
                        if (length - index == 1) return "III";
                        break;
                    case 5:
                        if (length - index == 3) return "D";
                        if (length - index == 2) return "L";
                        if (length - index == 1) return "V";
                        break;
                    case 6:
                        if (length - index == 3) return "DC";
                        if (length - index == 2) return "LX";
                        if (length - index == 1) return "VI";
                        break;
                    case 7:
                        if (length - index == 3) return "DCC";
                        if (length - index == 2) return "LXX";
                        if (length - index == 1) return "VII";
                        break;
                    case 8:
                        if (length - index == 3) return "DCCC";
                        if (length - index == 2) return "LXXX";
                        if (length - index == 1) return "VIII";
                        break;
                }
            }

            return String.Empty;
        }
    }
}

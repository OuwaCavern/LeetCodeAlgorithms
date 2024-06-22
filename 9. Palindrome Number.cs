using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    internal class _9
    {
        public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public bool IsPalindrome(int x)
        {
            int reversedXinteger;
            string reversedX = Reverse(x.ToString());
            if (int.TryParse(reversedX, out reversedXinteger))
            {
                if (x == reversedXinteger)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
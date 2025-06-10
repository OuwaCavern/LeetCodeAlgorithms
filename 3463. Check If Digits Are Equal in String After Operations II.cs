using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    public class _3463
    {
        // https://leetcode.com/problems/check-if-digits-are-equal-in-string-after-operations-ii/
        /// First Attempt. Valid but gives a timeout after 650/684 testcases passed.
        //public bool HasSameDigits(string s)
        //{
        //    while(s.Length > 2)
        //    {
        //        s = Process1(s);
        //    }

        //    return s[0] == s[1];
        //}

        //private string Process1(string s)
        //{
        //    StringBuilder digits = new();
        //    for (int i = 0; i < s.Length - 1; i++)
        //    {
        //        digits.Append(((s[i] - '0') + (s[i + 1] - '0')) % 10);
        //    }
        //    return digits.ToString();
        //}


        //public bool HasSameDigits(string s)
        //{

        //}
    }
}

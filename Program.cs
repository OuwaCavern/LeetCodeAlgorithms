﻿using System.Runtime.CompilerServices;
using System;
using System.Linq;
using LeetCode_Algorithms;
using static LeetCode_Algorithms._2;

namespace Sandbox
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            _1 twosumalgorithm = new _1();
            twosumalgorithm.TwoSum([3, 2, 4], 6);
            ListNode l1 = new ListNode(9);
            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(9);
            l2.next.next = new ListNode(9);
            l2.next.next.next = new ListNode(9);
            l2.next.next.next.next = new ListNode(9);
            l2.next.next.next.next.next = new ListNode(9);
            l2.next.next.next.next.next.next = new ListNode(9);
            l2.next.next.next.next.next.next.next = new ListNode(9);
            l2.next.next.next.next.next.next.next.next = new ListNode(9);
            l2.next.next.next.next.next.next.next.next.next = new ListNode(9);
            _2 addtwonumbersalgo = new _2();
            addtwonumbersalgo.AddTwoNumbers(l1, l2);
            _3 longestSubstring = new _3();
            longestSubstring.LengthOfLongestSubstring("abcabcbb");
            Solution solution = new Solution();
        }
    }
}
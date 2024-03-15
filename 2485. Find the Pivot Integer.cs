using System.Runtime.CompilerServices;
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
            Solution solution = new Solution();
            int PivotInteger(int n)
            {
                int found = -1;
                var numbersSmallerThann = Enumerable.Range(0, n + 1);
                foreach (int x in numbersSmallerThann)
                {
                    int sumOfNumbersBetweenxAndn = 0;
                    var numbersSmallerThanx = Enumerable.Range(0, x+1);
                    int sumOfNumbersSmallerThanx = 0;
                    foreach (int num in numbersSmallerThanx)
                    {
                        sumOfNumbersSmallerThanx += num;
                    }
                    var numbersBetweenxAndn = Enumerable.Range(x, n - x + 1);
                    foreach (int num in numbersBetweenxAndn)
                    {
                        sumOfNumbersBetweenxAndn += num;
                    }
                    if (sumOfNumbersBetweenxAndn == sumOfNumbersSmallerThanx)
                    {
                        found = x;
                        break;
                    }
                }
                Console.WriteLine(found);
                return found;
            }
            PivotInteger(8);
        }
    }
}
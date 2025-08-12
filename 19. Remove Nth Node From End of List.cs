using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    internal class _19
    {
        // https://leetcode.com/problems/remove-nth-node-from-end-of-list/description/
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int length = 1;

            ListNode disposable = head;
            while (disposable.next != null)
            {
                length++;
                disposable = disposable.next;
            }
            length--;

            List<int> cleansedList = new List<int>();
            int placeToRemove = length - n;

            while (placeToRemove >= 0)
            {
                if (head.next == null && placeToRemove != 0)
                {
                    cleansedList.Add(head.val);
                    break;
                }
                else if (head.next == null)
                {
                    cleansedList.Add(head.val);
                    break;
                }
                else if (head.next.next == null && placeToRemove != 0)
                {
                    cleansedList.Add(head.next.val);
                    head = head.next;
                }
                else if (head.next.next != null && placeToRemove == 0)
                {
                    cleansedList.Add(head.next.next.val);
                    head = head.next.next;
                }
                else if (head.next != null && placeToRemove != 0)
                {
                    cleansedList.Add(head.val);
                    head = head.next;
                }

                placeToRemove--;
            }

            if (cleansedList.Count > 0)
            {
                ListNode result = new ListNode(cleansedList[0]);
                ListNode currentNode = result;
                for (int i = 1; i < cleansedList.Count; i++)
                {
                    currentNode.next = new ListNode(cleansedList[i]);
                    currentNode = currentNode.next;
                }

                return result;
            }
            else
            {
                return new ListNode();
            }
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

    }
}

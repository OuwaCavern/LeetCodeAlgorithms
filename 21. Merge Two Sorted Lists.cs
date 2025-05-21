using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LeetCode_Algorithms
{
    public class _21
    {
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

        private ListNode result = new ListNode();
        private ListNode RecursiveLists(ListNode list1, ListNode list2)
        {
            if (list1.val == 0 || list1.next == null)
            {
                EmptyListNodes(list2, result);
                return result;
            }
            else if(list2.val == 0 || list2.next == null)
            {
                EmptyListNodes(list1, result);
                return result;
            }
            
            
            if (list1.val >= list2.val)
            {
                result.next = new ListNode(list2.val);
            }
            else
            {
                result.next = new ListNode(list2.val);
            }

            if (list1.next == null || list2.next == null)
            {
                return result;
            }
            else
            {
                RecursiveLists(list1, list2);
                return result;
            }
        }

        private void EmptyListNodes(ListNode listToBeEmptied, ListNode listToBeFilled)
        {
            if (listToBeEmptied.val != 0)
            {
                listToBeFilled.next = new ListNode(listToBeEmptied.val);
                EmptyListNodes(listToBeEmptied, listToBeFilled);
            }
            else
            {
                return;
            }
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            return RecursiveLists(list1, list2);
        }
    }
}

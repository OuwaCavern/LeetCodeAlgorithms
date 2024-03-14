using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    internal class _2
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
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            // First attempt to create a working version when boths lists has only 3 elements
            int thirdL1Number = l1.val;
            l1 = l1.next;
            int secondL1Number = l1.val;
            l1 = l1.next;
            int firstL1Number = l1.val;
            int thirdL2Number = l2.val;
            l2 = l2.next;
            int secondL2Number = l2.val;
            l2 = l2.next;
            int firstL2Number = l2.val;

            string firstNumberString = $"{firstL1Number}{secondL1Number}{thirdL1Number}";
            int firstNumberInt;
            Int32.TryParse(firstNumberString, out firstNumberInt);

            string secondNumberString = $"{firstL2Number}{secondL2Number}{thirdL2Number}";
            int secondNumberInt;
            Int32.TryParse(secondNumberString, out secondNumberInt);

            int sum = firstNumberInt + secondNumberInt;
            string sumString = sum.ToString();
            int firstSumNumber = Int32.Parse(sumString.Substring(0, 1));
            int secondSumNumber = Int32.Parse(sumString.Substring(1,1));
            int thirdSumNumber = Int32.Parse(sumString.Substring(2,1));
            
            ListNode lresult = new ListNode(thirdSumNumber);
            lresult.next = new ListNode(secondSumNumber);
            lresult.next.next = new ListNode(firstSumNumber);
            Console.WriteLine(sum);

            return lresult;


            // Second attempt to create a version that works on all lists with n elements

            List<int> listOfCorrectOrderL1 = new List<int>();
            while (l1.next != null)
            {
                listOfCorrectOrderL1.Add(l2.val);
            }
            int numberOfElementsInL1 = listOfCorrectOrderL1.Count;
            string correctlySortedStringL1 = "";

            foreach (int n in listOfCorrectOrderL1) 
            {
                correctlySortedStringL1 += n;
            }
            int correctlySortedIntL1;
            Int32.TryParse(correctlySortedStringL1, out correctlySortedIntL1);

            List<int> listOfCorrectOrderL2 = new List<int>();
            int numberOfElementsInL2 = listOfCorrectOrderL2.Count;
            string correctlySortedStringL2 = "";

            foreach (int n in listOfCorrectOrderL2)
            {
                correctlySortedStringL2 += n;
            }
            int correctlySortedIntL2;
            Int32.TryParse(correctlySortedStringL2, out correctlySortedIntL2);

            int sums = correctlySortedIntL1 + correctlySortedIntL2;

            string sumStrings = sums.ToString();
            foreach ()


        }
    }
}

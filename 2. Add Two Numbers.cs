using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
            //int thirdL1Number = l1.val;
            //l1 = l1.next;
            //int secondL1Number = l1.val;
            //l1 = l1.next;
            //int firstL1Number = l1.val;
            //int thirdL2Number = l2.val;
            //l2 = l2.next;
            //int secondL2Number = l2.val;
            //l2 = l2.next;
            //int firstL2Number = l2.val;

            //string firstNumberString = $"{firstL1Number}{secondL1Number}{thirdL1Number}";
            //int firstNumberInt;
            //Int32.TryParse(firstNumberString, out firstNumberInt);

            //string secondNumberString = $"{firstL2Number}{secondL2Number}{thirdL2Number}";
            //int secondNumberInt;
            //Int32.TryParse(secondNumberString, out secondNumberInt);

            //int sum = firstNumberInt + secondNumberInt;
            //string sumString = sum.ToString();
            //int firstSumNumber = Int32.Parse(sumString.Substring(0, 1));
            //int secondSumNumber = Int32.Parse(sumString.Substring(1,1));
            //int thirdSumNumber = Int32.Parse(sumString.Substring(2,1));
            
            //ListNode lresult = new ListNode(thirdSumNumber);
            //lresult.next = new ListNode(secondSumNumber);
            //lresult.next.next = new ListNode(firstSumNumber);
            //Console.WriteLine(sum);

            //return lresult;


            // Second attempt to create a version that works on all lists with n elements

            List<int> listOfCorrectOrderL1 = new List<int>();
            while (l1 != null)
            {
                listOfCorrectOrderL1.Add(l1.val);
                l1 = l1.next;
            }
            string correctlySortedStringL1 = "";
            listOfCorrectOrderL1.Reverse();


            foreach (int n in listOfCorrectOrderL1) 
            {
                correctlySortedStringL1 += n;
            }
            BigInteger correctlySortedIntL1;
            BigInteger.TryParse(correctlySortedStringL1, out correctlySortedIntL1);

            List<int> listOfCorrectOrderL2 = new List<int>();
            while (l2 != null) 
            {
                listOfCorrectOrderL2.Add(l2.val);
                l2 = l2.next;
            }
            string correctlySortedStringL2 = "";
            listOfCorrectOrderL2.Reverse();

            foreach (int n in listOfCorrectOrderL2)
            {
                correctlySortedStringL2 += n;
            }
            BigInteger correctlySortedIntL2;
            BigInteger.TryParse(correctlySortedStringL2, out correctlySortedIntL2);

            BigInteger sum = correctlySortedIntL1 + correctlySortedIntL2;

            string sumString = sum.ToString();
            ListNode lresult = new ListNode(Int32.Parse(sumString.Substring(sumString.Length -1, 1)));
            ListNode currentNode = lresult;
            for (int i = sumString.Length - 2; i >= 0; i--)
            {
                currentNode.next = new ListNode(Int32.Parse(sumString.Substring(i, 1)));
                currentNode = currentNode.next;
            }
            return lresult;
        }
    }
}

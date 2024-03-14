using System.Runtime.CompilerServices;
using System;
using System.Linq;

namespace Sandbox
{
    public class Solution
    {
        public static void Main(string[] args)
        {
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
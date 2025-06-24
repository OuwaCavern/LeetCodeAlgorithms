using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    public class _7
    {
        public int Reverse(int x)
        {
            if (x < 10 && x >= 0)
                return x;

            static void RemoveAt<T>(ref T[] arr, int index)
            {
                for (int a = index; a < arr.Length - 1; a++)
                {
                    arr[a] = arr[a + 1];
                }
                Array.Resize(ref arr, arr.Length - 1);
            }

            int theResult;
            if (x > 0)
            {
                if (!Int32.TryParse(string.Join("", x.ToString().ToArray().Reverse()), out theResult))
                {
                    return 0;
                }
            }
            else
            {
                char[] theArrayToRemoveSignFrom = x.ToString().ToCharArray();
                RemoveAt(ref theArrayToRemoveSignFrom, 0);
                if (!Int32.TryParse(string.Join("", theArrayToRemoveSignFrom.Append('-').Reverse()), out theResult))
                {
                    return 0;
                }
            }
            return theResult;
        }
    }
}

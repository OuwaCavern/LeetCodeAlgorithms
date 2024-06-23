using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace LeetCode_Algorithms
//{
//    internal class _7
//    {
//        public int Reverse(int x)
//        {
//            static void RemoveAt<T>(ref T[] arr, int index)
//            {
//                for (int a = index; a < arr.Length - 1; a++)
//                {
//                    arr[a] = arr[a + 1];
//                }
//                Array.Resize(ref arr, arr.Length - 1);
//            }
//            int theResult;
//            if(Int32.Sign(x) != -) 
//            {
//                if (!Int32.TryParse(string.Join("", x.ToString().ToArray().Reverse()), out theResult))
//                {
//                    return 0;
//                }
//            }
//            else
//            {
//                var theArrayToRemoveSignFrom = x.ToString().ToCharArray();
//                RemoveAt(ref theArrayToRemoveSignFrom, theArrayToRemoveSignFrom.Length - 1);
//                theArrayToRemoveSignFrom.Append('-');
//                if (!Int32.TryParse(string.Join(' ', theArrayToRemoveSignFrom.Reverse()), out theResult));
//                {
//                    return 0;
//                }
//            }
//            return theResult;
//        }
//    }
//}

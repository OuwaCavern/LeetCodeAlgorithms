using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorithms
{
    internal class _22
    {
        public IList<string> GenerateParenthesis(int n)
        {
            int totalNumberOfParentheses = MathFactorial(n);
            IList<string> result = new List<string>();
            StringBuilder newSetOfParentheses = new();
            int numberOfOpenParenthses = 0;
            
            while (totalNumberOfParentheses > 0)
            {
                if (numberOfOpenParenthses < 0)
                {
                    newSetOfParentheses.Append("(");
                    totalNumberOfParentheses--;
                }
                else
                {
                    newSetOfParentheses.Append(')');
                    totalNumberOfParentheses--;
                }
                result.Add(newSetOfParentheses.ToString());
            }
        }


        // Unrelated algorithm to the problem I spontenaously wrote
        public int MathFactorial(int num)
        {
            if (num > 1)
            {
                int result = (num * num - 1);
                num = num - 2;

                while (num > 1)
                {
                    result = result * (num - 1);
                    num--;
                }
                return result;
                }
            else
            {
                return 1;
            }
        }
    }
}

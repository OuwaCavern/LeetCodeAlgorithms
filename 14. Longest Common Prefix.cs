using System.Text;

namespace LeetCode_Algorithms
{
    internal class _14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1)
            {
                return strs[0];
            }
            else
            {
                StringBuilder stringBuilder = new();
                for (int i = 0; i < strs[0].Length; i++)
                {
                    char characterOfFirstString = strs[0][i];
                    for (int j = 1; j < strs.Length; j++)
                    {
                        if (strs[j].Length > i )
                        {
                            if (strs[j][i] == characterOfFirstString && j == strs.Length - 1)
                            {
                                stringBuilder.Append(characterOfFirstString);
                            }
                            else if (strs[j][i] == characterOfFirstString)
                            {
                                continue;
                            }
                            else
                            {
                                return stringBuilder.ToString();
                            }
                        }
                        else
                        {
                            return stringBuilder.ToString();
                        }
                    }
                }
                return stringBuilder.ToString();
            }
        }
    }
}
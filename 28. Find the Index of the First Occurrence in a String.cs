namespace LeetCode_Algorithms
{
    internal class _28
    {
        public int StrStr(string haystack, string needle)
        {
            List<char> attemptedNeedle = new();
            int startIndex = -1;
            int j = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (needle[j] == haystack[i] && attemptedNeedle.Count == 0)
                {
                    startIndex = i;
                    attemptedNeedle.Add(haystack[i]);
                    if (j < needle.Length - 1)
                    {
                        j++;
                    }
                }
                else if (needle[j] == haystack[i] && attemptedNeedle.Count != needle.Length)
                {
                    attemptedNeedle.Add(haystack[i]);
                    if (j < needle.Length - 1)
                    {
                        j++;
                    }
                }
                else if (attemptedNeedle.Count == needle.Length)
                {
                    break;
                }
                else if(i != haystack.Length -1)
                {
                    attemptedNeedle.Clear();
                    continue;
                }
                else
                {
                    return -1;
                }
            }
            return startIndex;
        }
    }
}

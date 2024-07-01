namespace LeetCode_Algorithms
{
    internal class _20
    {
        public bool IsValid(string s)
        {
            if (s.Length  <= 1) return false;

            Stack<char> parenthesesStack = new();
            Dictionary<char, char> parentheses = new();
            parentheses.Add('(', ')');
            parentheses.Add('[', ']');
            parentheses.Add('{', '}');

            foreach (char c in s)
            {
                if (parentheses.ContainsKey(c))
                {
                    parenthesesStack.Push(c);
                }
                else if (parenthesesStack.Count > 0)
                {
                    if (InverseParentheses(c) == parenthesesStack.Peek())
                    {
                        parenthesesStack.Pop();
                    }
                    else return false;
                }
                else if (parenthesesStack.Count == 0) return false;
            }

            return parenthesesStack.Count == 0;
        }
        private char InverseParentheses(char parentheses)
        {
            switch (parentheses)
            {
                case '(':
                    return ')';
                case ')':
                    return '(';
                case '[':
                    return ']';
                case ']':
                    return '[';
                case '{':
                    return '}';
                case '}':
                    return '{';
            }
            return parentheses;
        }
    }
}

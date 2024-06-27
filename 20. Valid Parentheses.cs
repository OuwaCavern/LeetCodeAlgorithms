namespace LeetCode_Algorithms
{
    internal class _20
    {
        public bool IsValid(string s)
        {
            List<char> parentheses = new(s);

            for (int i = 0; i < parentheses.Count; i++)
            {
                char theOpenedParentheses = parentheses[i];
                parentheses.Remove(theOpenedParentheses);
                if (theOpenedParentheses == '(' || theOpenedParentheses == '[' || theOpenedParentheses == '{')
                {
                    for (int j = i + 1; j < parentheses.Count; j++)
                    {
                        if (theOpenedParentheses == InverseParentheses(parentheses[j]))
                        {
                            parentheses.RemoveAt(j);
                            break;
                        }
                        else if (j == parentheses.Count - 1)
                        {
                            return false;
                        }
                    }
                }
                else if (theOpenedParentheses == ')' || theOpenedParentheses == ']' || theOpenedParentheses == '}') 
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
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

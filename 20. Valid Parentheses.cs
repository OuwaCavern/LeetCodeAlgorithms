namespace LeetCode_Algorithms
{
    internal class _20
    {
        public bool IsValid(string s)
        {
            const char normalParenthesesOpen = '(';
            const char normalParenthesesClose = ')';
            const char squareParenthesesOpen = '[';
            const char squareParenthesesClose = ']';
            const char curlyParenthsesOpen = '{';
            const char curlyParenthesesClose = '}';

            bool normalParenthesesOpened = false;
            bool squareParenthesesOpened = false;
            bool curlyParenthesesOpened = false;


            foreach (char c in s)
            {
                if (c == normalParenthesesOpen)
                {
                    normalParenthesesOpened = true;
                }
                else if (c == squareParenthesesOpen)
                {
                    squareParenthesesOpened = true;
                }
                else if (c == curlyParenthsesOpen)
                {
                    curlyParenthesesOpened = true;
                }
                else if (c == normalParenthesesClose)
                {
                    if (normalParenthesesOpened && (squareParenthesesOpened || curlyParenthesesOpened))
                    {
                        return false;
                    }
                    normalParenthesesOpened = false;
                }
                else if (c == squareParenthesesClose)
                {
                    if (squareParenthesesOpened && (normalParenthesesOpened || curlyParenthesesOpened))
                    {
                        return false;
                    }
                    squareParenthesesOpened = false;
                }
                else if (c == curlyParenthesesClose)
                {
                    if (curlyParenthesesOpened && (squareParenthesesOpened || normalParenthesesOpened))
                    {
                        return false;
                    }
                    curlyParenthesesOpened = false;
                }
            }
            return (!normalParenthesesOpened) && (!squareParenthesesOpened) && (!curlyParenthesesOpened);
        }
    }
}

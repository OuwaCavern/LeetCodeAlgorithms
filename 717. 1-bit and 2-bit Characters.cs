namespace LeetCode_Algorithms;

// https://leetcode.com/problems/1-bit-and-2-bit-characters/
internal class _717
{
    // Time complexity: O(n) where n is the length of the input array bits. We traverse the array once.
    // Space complexity: O(1) since we are using a constant amount of extra space.
    public bool IsOneBitCharacter(int[] bits)
    {
        // preparations
        int length = bits.Length;
        int lastIndex = length - 1;
        bool matchFoundForOne = true; // the only way to create a 2-bit character is to start with a 1 so we will use this variable to track that. the reason we start with true is because if it is a 1 character array, then it must be  [0] so we should get that as true.

        for (int i = 0; i < length; i++)
        {
            switch (bits[i]) 
            {
                case 0: // if the character is 0, it does not need a matching character in the array to form a valid combination but if it is the last character and there is an unmatched 1 before it, it has to be used to create a 2-bit character.
                    if (!matchFoundForOne && i == lastIndex)
                        return false;
                    else
                        matchFoundForOne = true;

                    break;

                case 1: // if the character is 1, it has to be matched with another 1 or 0 so we set matchFoundForOne variable to false to indicate that we have an unmatched 1.
                    if (!matchFoundForOne)
                        matchFoundForOne = true;
                    else
                        matchFoundForOne = false;

                    break;
            }
        }

        return matchFoundForOne;
    }
}

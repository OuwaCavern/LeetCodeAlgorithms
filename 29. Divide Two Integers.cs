namespace LeetCode_Algorithms;

internal class _29
{
    public int Divide(int dividend, int divisor)
    {
        int timesAppeared = 0;
        bool sameSigns = !(int.IsPositive(dividend) ^ int.IsPositive(divisor));
        int result = HandleEdgeCases(ref dividend, ref divisor, sameSigns);

        if (result != 123)
            return result;

        int absDividend = GetAbsoluteValueOfInt32Safe(dividend);
        int absDivisor = GetAbsoluteValueOfInt32Safe(divisor);

        if (dividend == int.MinValue)
        {
            absDividend++;
            timesAppeared++;
            absDividend -= absDivisor;
        }

        while (absDividend >= absDivisor)
        {
            timesAppeared++;
            absDividend -= absDivisor;
        }

        return sameSigns ? timesAppeared : -timesAppeared;
    }

    private int HandleEdgeCases(ref int dividend, ref int divisor, bool sameSigns)
    {
        if (GetAbsoluteValueOfInt32Safe(divisor) > GetAbsoluteValueOfInt32Safe(dividend) 
            || (divisor == int.MinValue && dividend != divisor))
            return 0;

        if (divisor == 1)
            return dividend;
        else if (divisor == -1)
            return sameSigns ? GetAbsoluteValueOfInt32Safe(dividend) : -dividend;

        return 123;
    }

    private int GetAbsoluteValueOfInt32Safe(int theValue)
    {
        if (theValue == int.MinValue)
            return int.MaxValue;
        else
            return Math.Abs(theValue);
    }
}

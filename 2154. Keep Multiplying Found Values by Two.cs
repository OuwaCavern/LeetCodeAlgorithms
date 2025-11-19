namespace LeetCode_Algorithms;

internal class _2154
{
    public int FindFinalValue(int[] nums, int original)
    {
        HashSet<int> potentialCandidates = [];

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % original == 0) 
                potentialCandidates.Add(nums[i]);
        }

        if (!potentialCandidates.Contains(original)) return original;

        for (int i = 0; i < potentialCandidates.Count; i++)
        {
            original *= 2;
            if (!potentialCandidates.TryGetValue(original, out int doesNotMatter))
                return original;
        }

        return original;
    }
    /// Brute Force Solution
    //public int FindFinalValue(int[] nums, int original)
    //{
    //    Array.Sort(nums);

    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        if (nums[i] == original)
    //            original *= 2;
    //    }

    //    return original;
    //}
}

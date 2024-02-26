namespace LeetCodeProblems;
public static class Problem9_LongestConsecutiveSequence
{
    public static int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        HashSet<int> set = new(nums);
        int maxCount = 1;
        foreach (int num in set)
        {
            if (set.Contains(num - 1))
            {
                continue;
            }

            int count = 1;
            while (set.Contains(num + count))
            {
                ++count;
            }

            maxCount = Math.Max(count, maxCount);
        }

        return maxCount;
    }
}

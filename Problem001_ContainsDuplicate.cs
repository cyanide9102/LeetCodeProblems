namespace LeetCodeProblems;

public static class Problem001_ContainsDuplicate
{
    public static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> uniqueNumbers = [];
        for (int i = 0; i < nums.Length; ++i)
        {
            if (uniqueNumbers.Contains(nums[i]))
            {
                return true;
            }
            uniqueNumbers.Add(nums[i]);
        }
        return false;
    }
}

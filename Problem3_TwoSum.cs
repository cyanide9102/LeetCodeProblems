namespace LeetCodeProblems;

public static class Problem3_TwoSum
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> values = [];
        for (int i = 0; i < nums.Length; ++i)
        {
            if (values.TryGetValue(target - nums[i], out int index))
            {
                return [index, i];
            }

            values.TryAdd(nums[i], i);
        }
        return [0, 0];
    }
}

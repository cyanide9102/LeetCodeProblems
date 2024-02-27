namespace LeetCodeProblems;

public static class Problem003_TwoSum
{
    public static int[] TwoSum(int[] nums, int target)
    {
        if (nums.Length == 2)
        {
            return [0, 1];
        }

        Dictionary<int, int> values = [];
        for (int i = 0; i < nums.Length; ++i)
        {
            if (values.TryGetValue(target - nums[i], out int index))
            {
                return [index, i];
            }

            values.TryAdd(nums[i], i);
        }

        throw new Exception("No solution found!");
    }
}

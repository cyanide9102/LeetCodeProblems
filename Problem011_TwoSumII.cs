namespace LeetCodeProblems;

public static class Problem011_TwoSumII
{
    public static int[] TwoSum(int[] numbers, int target)
    {
        int i = 0;
        int j = numbers.Length - 1;
        while (i < j)
        {
            int twoSum = numbers[i] + numbers[j];
            if (twoSum > target)
            {
                --j;
            }
            else if (twoSum < target)
            {
                ++i;
            }
            else
            {
                return [i + 1, j + 1];
            }
        }

        throw new Exception("No solution found!");
    }
}

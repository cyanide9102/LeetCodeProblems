namespace LeetCodeProblems;

public static class Problem011_TwoSumII
{
    public static int[] TwoSum(int[] numbers, int target)
    {
        int i = 0;
        int upperLimit = numbers.Length - 1;
        while (i < numbers.Length - 1)
        {
            int j = i + 1;
            while (j <= upperLimit)
            {
                int twoSum = numbers[i] + numbers[j];
                if (twoSum == target)
                {
                    return [i + 1, j + 1];
                }
                else if (twoSum > target)
                {
                    upperLimit = j;
                    break;
                }
                else
                {
                    ++j;
                }
            }
            ++i;
        }

        throw new Exception("No solution found!");
    }
}

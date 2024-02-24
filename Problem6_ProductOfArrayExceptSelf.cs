namespace LeetCodeProblems;

public static class Problem6_ProductOfArrayExceptSelf
{
    public static int[] ProductExceptSelf(int[] nums)
    {
        int[] prefix = new int[nums.Length];
        int[] postfix = new int[nums.Length];
        int[] numsProduct = new int[nums.Length];

        for (int i = 0; i < nums.Length; ++i)
        {
            if (i == 0)
            {
                prefix[i] = nums[i];
            }
            else
            {
                prefix[i] = nums[i] * prefix[i - 1];
            }
        }

        for (int i = nums.Length - 1; i >= 0; --i)
        {
            if (i == nums.Length - 1)
            {
                postfix[i] = nums[i];
            }
            else
            {
                postfix[i] = nums[i] * postfix[i + 1];
            }
        }

        for (int i = 0; i < nums.Length; ++i)
        {
            if (i == 0)
            {
                numsProduct[i] = 1 * postfix[i + 1];
            }
            else if (i == nums.Length - 1)
            {
                numsProduct[i] = prefix[i - 1] * 1;
            }
            else
            {
                numsProduct[i] = prefix[i - 1] * postfix[i + 1];
            }
        }

        return numsProduct;
    }
}

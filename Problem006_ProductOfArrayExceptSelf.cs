namespace LeetCodeProblems;

public static class Problem006_ProductOfArrayExceptSelf
{
    public static int[] ProductExceptSelf(int[] nums)
    {
        int[] numsProduct = new int[nums.Length];

        int prefix = 1;
        for (int i = 0; i < nums.Length; ++i)
        {
            numsProduct[i] = prefix;
            prefix *= nums[i];
        }

        int postfix = 1;
        for (int i = nums.Length - 1; i >= 0; --i)
        {
            numsProduct[i] *= postfix;
            postfix *= nums[i];
        }

        return numsProduct;
    }
}

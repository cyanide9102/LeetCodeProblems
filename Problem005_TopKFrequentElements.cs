namespace LeetCodeProblems;

public static class Problem005_TopKFrequentElements
{
    public static int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> numsCount = [];
        foreach (var num in nums)
        {
            if (numsCount.TryGetValue(num, out int frequency))
            {
                ++numsCount[num];
            }
            else
            {
                numsCount.Add(num, 1);
            }
        }

        List<List<int>> numsFrequency = new(nums.Length + 1);
        for (int i = 0; i < nums.Length + 1; ++i)
        {
            numsFrequency.Add([]);
        }

        foreach (var numCount in numsCount)
        {
            numsFrequency[numCount.Value].Add(numCount.Key);
        }

        List<int> result = [];
        for (int i = numsFrequency.Count - 1; i > 0; --i)
        {
            for (int j = 0; j < numsFrequency[i].Count; ++j)
            {
                result.Add(numsFrequency[i][j]);
                if (result.Count == k)
                {
                    return [.. result];
                }
            }
        }
        return [];
    }
}

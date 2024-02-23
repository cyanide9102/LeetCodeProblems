namespace LeetCodeProblems
{
    public static class Problem5_TopKFrequentElements
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            if (nums.Length == 1 && k == 1)
            {
                return [nums[0]];
            }

            Dictionary<int, int> numsFrequency = [];
            foreach (int num in nums)
            {
                if (numsFrequency.TryGetValue(num, out int frequency))
                {
                    ++numsFrequency[num];
                }
                else
                {
                    numsFrequency.Add(num, 1);
                }
            }

            List<(int, int)> numsFrequencyTopK = numsFrequency.OrderByDescending(x => x.Value)
                                                              .Take(k)
                                                              .Select(kvp => (kvp.Key, kvp.Value))
                                                              .ToList();

            int[] numsTopK = new int[k];
            int index = 0;
            foreach ((int, int) topK in numsFrequencyTopK)
            {
                numsTopK[index] = topK.Item1;
                ++index;
            }

            return numsTopK;
        }
    }
}

using System.Text;

namespace LeetCodeProblems;

public static class Problem004_GroupAnagrams
{
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> anagramsMap = [];

        foreach (string word in strs)
        {
            int[] alphabetsCount = new int[26];
            foreach (char alphabet in word)
            {
                ++alphabetsCount[(int)alphabet - (int)'a'];
            }

            StringBuilder keyBuilder = new();
            foreach (int count in alphabetsCount)
            {
                keyBuilder.Append('\'').Append(count).Append('\'');
            }

            string key = keyBuilder.ToString();
            if (anagramsMap.TryGetValue(key, out var anagrams))
            {
                anagrams.Add(word);
            }
            else
            {
                anagramsMap.Add(key, [word]);
            }
        }

        IList<IList<string>> result = [];
        foreach (List<string> item in anagramsMap.Select(g => g.Value).ToList())
        {
            result.Add(item);
        }

        return result;
    }
}

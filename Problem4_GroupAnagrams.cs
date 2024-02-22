namespace LeetCodeProblems;

public static class Problem4_GroupAnagrams
{
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        IList<IList<string>> groupedAnagrams = [];

        foreach (string word in strs)
        {
            if (groupedAnagrams.Any(x => x.Any(y => y.Equals(word, StringComparison.OrdinalIgnoreCase))))
            {
                continue;
            }

            IList<string> anagrams = [];

            Dictionary<char, int> characterMap = [];
            for (int i = 0; i < word.Length; ++i)
            {
                if (characterMap.TryGetValue(word[i], out int _))
                {
                    ++characterMap[word[i]];
                }
                else
                {
                    characterMap.Add(word[i], 1);
                }
            }

            foreach (string nextWord in strs)
            {
                if (word == "" && nextWord.Length > 0)
                {
                    continue;
                }

                Dictionary<char, int> characterMapCopied = new(characterMap);
                for (int i = 0; i < nextWord.Length; ++i)
                {
                    if (characterMapCopied.TryGetValue(nextWord[i], out int count))
                    {
                        --count;
                        if (count == 0)
                        {
                            characterMapCopied.Remove(nextWord[i]);
                        }
                        else
                        {
                            characterMapCopied[nextWord[i]] = count;
                        }
                    }
                }

                if (characterMapCopied.Count == 0 && word.Length == nextWord.Length)
                {
                    anagrams.Add(nextWord);
                }
            }

            groupedAnagrams.Add(anagrams);
        }

        return groupedAnagrams;
    }
}

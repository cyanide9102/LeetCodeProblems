namespace LeetCodeProblems;

public static class Problem002_ValidAnagram
{
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> characterMap = [];
        for (int i = 0; i < s.Length; ++i)
        {
            if (characterMap.TryGetValue(s[i], out int _))
            {
                ++characterMap[s[i]];
            }
            else
            {
                characterMap.Add(s[i], 1);
            }
        }

        for (int i = 0; i < t.Length; ++i)
        {
            if (characterMap.TryGetValue(t[i], out int count))
            {
                --count;
                if (count == 0)
                {
                    characterMap.Remove(t[i]);
                }
                else
                {
                    characterMap[t[i]] = count;
                }
            }
        }

        if (characterMap.Count != 0)
        {
            return false;
        }

        return true;
    }
}

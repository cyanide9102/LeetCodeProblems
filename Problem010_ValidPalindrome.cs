using System.Text;

namespace LeetCodeProblems;
public static class Problem010_ValidPalindrome
{
    public static bool IsPalindrome(string s)
    {
        StringBuilder builder = new();
        foreach (char c in s.ToLower())
        {
            if (c is >= (char)48 and <= (char)57 or >= (char)97 and <= (char)122)
            {
                builder.Append(c);
            }
        }

        string str = builder.ToString();
        int i = 0;
        int j = str.Length - 1;
        while (true)
        {
            if (i >= j)
            {
                break;
            }

            if (str[i] != str[j])
            {
                return false;
            }

            ++i;
            --j;
        }

        return true;
    }
}

namespace LeetCodeProblems;
public class Problem8_StringEncodeAndDecode
{
    public static string Encode(IList<string> strs)
    {
        string encodedString = string.Empty;
        foreach (string str in strs)
        {
            encodedString += str;
            encodedString += "][><][";
        }

        return encodedString;
    }

    public static List<string> Decode(string s)
    {
        string splitter = @"][><][";
        List<string> strs = [.. s.Split(splitter, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)];
        return strs;
    }
}

namespace Leetcode.LongestPalindrome;

public class Solution
{
    private Dictionary<string, bool> _cache = new ();

    public string LongestPalindrome(string s)
    {
        var result = string.Empty;
        for (var i =0; i < s.Length; i++)
        {
            for (var j = i; j < s.Length; j++)
            {
                var substring = s.Substring(i, j - i + 1);
                if (!this._cache.ContainsKey(substring))
                {
                    var isPalindrome = IsPalindrome(substring);
                    CacheSubstring(substring, isPalindrome, ref result);
                }
            }
        }
        return result;
    }

    private void CacheSubstring(string substring, bool isPalindrome, ref string result)
    {
        this._cache.Add(substring, isPalindrome);
        if (isPalindrome && result.Length < substring.Length)
        {
            result = substring;
        }
    }

    private bool IsPalindrome(string s)
    {
        var cleanString = s.ToLower().Where(char.IsLetterOrDigit).ToArray();
        if (cleanString.Length == 0) return true;

        var steps = cleanString.Count() / 2;
        for (var i = 0; i <= steps; ++i)
        {
            if(cleanString[i] != cleanString[cleanString.Length - 1 - i])
                return false;
        }
        return true;
    }
}
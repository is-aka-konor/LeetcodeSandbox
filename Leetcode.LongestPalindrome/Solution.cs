namespace Leetcode.LongestPalindrome;

public class Solution
{
    private Dictionary<string, bool> _cache = new ();

    public string LongestPalindrome(string s)
    {
        var result = string.Empty;
        for (var i = 0; i < s.Length; ++i)
        {
            var palindrome = GetPalindrome(s, i, i);
            if (palindrome.Length > result.Length)
            {
                result = palindrome;
            }

            palindrome = GetPalindrome(s, i, i + 1);
            if (palindrome.Length > result.Length)
            {
                result = palindrome;
            }
        }
        return result;
    }
    
    private string GetPalindrome(string s, int start, int end)
    {
        var key = $"{start}-{end}";
        if (_cache.ContainsKey(key))
        {
            return _cache[key] ? s.Substring(start, end - start + 1) : string.Empty;
        }

        while (start >= 0 && end < s.Length && s[start] == s[end])
        {
            start--;
            end++;
        }

        _cache.Add(key, end - start - 1 > 0);
        return _cache[key] ? s.Substring(start + 1, end - start - 1) : string.Empty;
    }
}
using System;
namespace Leetcode.ValidPalindrome
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            var cleanString = s.ToLower().Where(ch => char.IsLetterOrDigit(ch)).ToArray();
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
}


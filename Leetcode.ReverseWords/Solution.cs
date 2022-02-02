using System.Text;
using System.Text.RegularExpressions;

namespace Leetcode.ReverseWords
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            s = s.TrimStart().TrimEnd();
            s = Regex.Replace(s, @"\s+", " ");
            var words = s.Split(' ');
            if (words.Length == 1) return words[0];
            var result = new StringBuilder();
            for (var i = words.Length - 1; i >= 0; --i)
            {
                result.Append(words[i]);
                result.Append(' ');
            }
            return result.ToString().TrimEnd();
        }
    }
}

namespace Leetcode.GroupAnagrams;

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var result = new List<IList<string>>();
        var cache = new Dictionary<string, IEnumerable<string>>();
        foreach (var str in strs) {
            var sortedStr = string.Concat(str.OrderBy(c => c));
            if (!cache.ContainsKey(sortedStr)) {
                cache.Add(sortedStr, new List<string>());
            }
            cache[sortedStr] = cache[sortedStr].Concat(new[] { str });
        }
        foreach (var kvp in cache) {
            result.Add(kvp.Value.ToList());
        }
        return result;
    }
}
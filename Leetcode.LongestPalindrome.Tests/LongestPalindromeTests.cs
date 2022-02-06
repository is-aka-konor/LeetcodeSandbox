using Xunit;

namespace Leetcode.LongestPalindrome.Tests;

public class LongestPalindromeTests
{
    [Theory]
    [InlineData("aba","aba")]
    [InlineData("babad","bab")]
    [InlineData("cbbd","bb")]
    [InlineData("cbbdaaaaa","aaaaa")]
    [InlineData("abcdrets","a")]
    public void ShouldPassLongestPalindromeTests(string input, string output)
    {
        var solutionImplementation = new Solution();
        var target = solutionImplementation.LongestPalindrome(input);
        Assert.Equal(output, target);
    }
}
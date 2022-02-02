using System;
using Xunit;

namespace Leetcode.ReverseWords.Tests
{
    public class ReverseWordsTests
    {
        [Theory]
        [InlineData("the sky is blue", "blue is sky the")]
        [InlineData("  hello world  ", "world hello")]
        [InlineData("a good   example", "example good a")]
        public void ShouldPassReverseWordsTests(string input, string target)
        {
            var solutionImplementation = new Solution();
            var result = solutionImplementation.ReverseWords(input);
            Assert.True(target.Equals(result, StringComparison.OrdinalIgnoreCase));
        }
    }
}
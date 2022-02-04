using Xunit;
using System;

namespace Leetcode.ReverseWordsII.Tests
{
    public class ReverseWordsIITest
    {
        [Theory]
        [InlineData("the sky is blue", "blue is sky the")]
        [InlineData("a", "a")]
        [InlineData("hello world", "world hello")]
        [InlineData("a good example", "example good a")]
        public void ShouldPassReverseWordsTests(string input, string output)
        {
            var solution = new Solution();
            var target = solution.ReverseWords(input.ToCharArray());
            Assert.Equal(output.ToCharArray(), target);
        }
    }
}

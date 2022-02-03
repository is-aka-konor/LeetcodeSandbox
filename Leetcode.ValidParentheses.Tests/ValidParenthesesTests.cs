using Xunit;

namespace Leetcode.ValidParentheses.Tests
{
    public class ValidParenthesesTests
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("((([])))", true)]
        [InlineData("((([)]))", false)]
        [InlineData("{[]", false)]
        public void ShouldPassValidParenthesesTests(string input, bool output)
        {
            var solutionImplementation = new Solution();
            var result = solutionImplementation.IsValid(input);
            Assert.Equal(output, result);
        }
    }
}
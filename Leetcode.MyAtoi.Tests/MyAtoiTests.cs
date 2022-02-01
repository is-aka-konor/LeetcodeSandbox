using Xunit;

namespace Leetcode.MyAtoi.Tests;

public class MyAtoiTests
{
    [Theory]
    [InlineData("   42", 42)]
    [InlineData("   -42 .0", -42)]
    [InlineData("4193 with words", 4193)]
    [InlineData("   some . words -4193 with words 13", 0)]
    [InlineData("words and 987", 0)]
    [InlineData("-91283472332", -2147483648)]
    [InlineData("-+12",0)]
    [InlineData("", 0)]
    [InlineData("      ", 0)]
    [InlineData("+", 0)]
    [InlineData("20000000000000000000", 2147483647)]
    [InlineData("  0000000000012345678", 12345678)]
    [InlineData("123+45", 123)]
    [InlineData("00000-42a1234", 0)]
    public void ShouldPassMyAtoiTests(string input, int target)
    {
        var solutionImplementation = new Solution();
        var result = solutionImplementation.MyAtoi(input);
        Assert.Equal(target, result);
    }
}

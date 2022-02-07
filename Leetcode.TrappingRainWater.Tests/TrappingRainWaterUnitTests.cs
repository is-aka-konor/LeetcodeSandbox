using Xunit;

namespace Leetcode.TrappingRainWater.Tests;

public class TrappingRainWaterUnitTests
{
    [Theory]
    [InlineData(new int[]{0,1,0,2,1,0,1,3,2,1,2,1}, 6)]
    [InlineData(new int[]{4,2,0,3,2,5}, 9)]
    [InlineData(new int[]{0,1,2,3,2,1}, 0)]
    [InlineData(new int[]{0,1,0,0,0,1}, 3)]
    public void ShouldPassTrappingRainWaterTests(int[] input, int expected)
    {
        var solutionImplementation = new Solution();
        var result = solutionImplementation.Trap(input);
        Assert.Equal(expected,result);
    }
}
using Xunit;

namespace Leetcode.SumTwo.Tests;

public class SumTwoInput
{
    public int[] Input { get; set; } 
    public int Target { get; set; }
    public int[] Result { get; set; } = new int[2];
}

public class TwoSumTests
{
    [Theory]
    [MemberData(nameof(SumTwoData), MemberType = typeof(TwoSumTests))]
    public void SohuldPassTests(SumTwoInput input)
    {
        var solution = new Solution();
        var solutionResult = solution.TwoSum(input.Input, input.Target);
        var tmp = input.Result == solutionResult;
        Assert.True(solutionResult[0] == input.Result[0]
            && solutionResult[1] == input.Result[1]);
    }
    public static TheoryData<SumTwoInput> SumTwoData =>
        new TheoryData<SumTwoInput>
        {
            new SumTwoInput() {
                Input =  new int[] { 2, 7, 11, 15 },
                Target = 9,
                Result = new int[] { 0, 1 }
            },
            new SumTwoInput() {
                Input =  new int[] { 3, 2, 4 },
                Target = 6,
                Result = new int[] { 1, 2 }
            },
            new SumTwoInput() {
                Input =  new int[] { 3, 3 },
                Target = 6,
                Result = new int[] { 0, 1 }
            },
            new SumTwoInput() {
                Input =  new int[] { 0, 3, 3, -9 },
                Target = -9,
                Result = new int[] { 0, 3 }
            },

            new SumTwoInput() {
                Input =  new int[] { -4, -9, 3, -5 },
                Target = -9,
                Result = new int[] { 0, 3 }
            },

            new SumTwoInput() {
                Input =  new int[] { -4, 2, 13, 3, 5 },
                Target = 9,
                Result = new int[] { 0, 2 }
            },
            new SumTwoInput() {
                Input =  new int[] { 0, 4, 3, 0 },
                Target = 0,
                Result = new int[] { 0, 3 }
            },
            new SumTwoInput() {
                Input =  new int[] { -3, 4, 3, 90 },
                Target = 0,
                Result = new int[] { 0, 2 }
            },
        };
}

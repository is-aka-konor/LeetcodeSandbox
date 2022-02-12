using Xunit;

namespace Leetcode.SetMatrixZeroes.Tests;

public class SetZeroTestInput
{
    public int[][] Input { get; set; }
    public int[][] Output { get; set; }

}
public class SetZeroesTests
{
    [Theory]
    [MemberData(nameof(SetZeroTestData), MemberType = typeof(SetZeroesTests))]
    public void ShouldPassSetZeroesTests(SetZeroTestInput testData)
    {
        var solutionImplementation = new Solution();
        solutionImplementation.SetZeroes(testData.Input);
        Assert.Equal(testData.Output, testData.Input);
    }

    public static TheoryData<SetZeroTestInput> SetZeroTestData =>
        new TheoryData<SetZeroTestInput>
        {
            new SetZeroTestInput
            {
                Input = new int[][]
                {
                    new int[] { 1, 1, 1, 1 },
                    new int[] { 1, 0, 1, 1 },
                    new int[] { 1, 1, 1, 1 }
                },
                Output = new int[][]
                {
                    new int[] { 1, 0, 1, 1},
                    new int[] { 0, 0, 0, 0 },
                    new int[] { 1, 0, 1, 1 }
                }
            },
            new SetZeroTestInput
            {
                Input = new int[][]
                {
                    new int[] { 0, 1, 2, 0 },
                    new int[] { 3, 4, 5, 2 },
                    new int[] { 1, 3, 1, 5 }
                },
                Output = new int[][]
                {
                    new int[] { 0, 0, 0, 0},
                    new int[] { 0, 4, 5, 0 },
                    new int[] { 0, 3, 1, 0 }
                }
            }
        };
}
using System.Collections.Generic;
using Xunit;

namespace Leetcode.SpiralMatrix.Tests;

public class SpiralMatrixTestInput
{
    public int[][] Input { get; set; }
    public IList<int> Output { get; set; }

}

public class SpiralMatrixTests
{
    [Theory]
    [MemberData(nameof(SpiralMatrixTestData), MemberType = typeof(SpiralMatrixTests))]
    public void ShouldPassSpiralMatrixTests(SpiralMatrixTestInput input)
    {
        var spiralMatrix = new Solution();
        var result = spiralMatrix.SpiralOrder(input.Input);
        Assert.Equal(input.Output, result);
    }
    
    public static TheoryData<SpiralMatrixTestInput> SpiralMatrixTestData =>
        new TheoryData<SpiralMatrixTestInput>
        {
            new SpiralMatrixTestInput
            {
                Input = new int[][]
                {
                    new int[] { 1, 2, 3 },
                    new int[] { 4, 5, 6 },
                    new int[] { 7, 8, 9 }
                },
                Output = new List<int> { 1, 2, 3, 6, 9, 8, 7, 4, 5 }
            },
            new SpiralMatrixTestInput()
            {
                Input = new int[][]
                {
                    new int[] { 1, 2, 3, 4 },
                    new int[] { 5, 6, 7, 8 },
                    new int[] { 9, 10, 11, 12 }
                },
                Output = new List<int> { 1,2,3,4,8,12,11,10,9,5,6,7 }
            }
        };
}
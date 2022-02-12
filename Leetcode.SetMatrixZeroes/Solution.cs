namespace Leetcode.SetMatrixZeroes;

public class Solution
{
    public void SetZeroes(int[][] matrix)
    {
        var rowsSet = new int[matrix.Length];
        var colsSet = new int[matrix[0].Length];
        // Mark rows and cols with 0
        for (var i = 0; i < matrix[0].Length; ++i)
        {
            for (var j = 0; j < matrix.Length; ++j)
            {
                if (matrix[j][i] == 0)
                {
                    rowsSet[j] = 1;
                    colsSet[i] = 1;
                }
            }
        }
        // Update matrix
        for (var i = 0; i < matrix[0].Length; ++i)
        {
            for (var j = 0; j < matrix.Length; ++j)
            {
                if (colsSet[i] == 1 || rowsSet[j] == 1)
                {
                    matrix[j][i] = 0;
                }
            }
        }
    }
}
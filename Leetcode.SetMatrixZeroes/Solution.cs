namespace Leetcode.SetMatrixZeroes;

public class Solution
{
    public void SetZeroes(int[][] matrix)
    {
        var rowsSet = new bool[matrix.Length];
        var colsSet = new bool[matrix[0].Length];
        // Mark rows and cols with 0
        for (var i = 0; i < matrix[0].Length; ++i)
        {
            for (var j = 0; j < matrix.Length; ++j)
            {
                if (matrix[j][i] == 0)
                {
                    rowsSet[j] = true;
                    colsSet[i] = true;
                }
            }
        }
        // Update matrix
        for (var i = 0; i < matrix[0].Length; ++i)
        {
            for (var j = 0; j < matrix.Length; ++j)
            {
                if ((colsSet[i] || rowsSet[j]) && matrix[j][i] != 0)
                {
                    matrix[j][i] = 0;
                }
            }
        }
    }
}
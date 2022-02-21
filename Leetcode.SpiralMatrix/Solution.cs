namespace Leetcode.SpiralMatrix;

public class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        var result = new List<int>();
        if (matrix.Length == 0)
        {
            return result;
        }

        var rows = matrix.Length;
        var columns = matrix[0].Length;
        var top = 0;
        var bottom = rows - 1;
        var left = 0;
        var right = columns - 1;

        while (result.Count < rows * columns)
        {
            for (var column = left; column <= right; column++)
            {
                result.Add(matrix[top][column]);
            }

            for (var row = top+1; row <= bottom; row++)
            {
                result.Add(matrix[row][right]);
            }
            
            if (top != bottom)
            {
                for (var col = right-1; col >= left; col--)
                {
                    result.Add(matrix[bottom][col]);
                }
            }

            if (left != right)
            {
                for (var row = bottom-1; row > top; row--)
                {
                    result.Add(matrix[row][left]);
                }
            }
            
            left++;
            right--;
            top++;
            bottom--;
        }
        return result;
    }
}
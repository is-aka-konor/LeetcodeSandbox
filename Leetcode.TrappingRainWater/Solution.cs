namespace Leetcode.TrappingRainWater;

public class Solution
{
    public int Trap(int[] height)
    {
        var result = 0;
        var maxLeft = 0;
        var maxRight = 0;
        // Volume of water in a point is equal to
        // min(maxLeft, maxRight) - height[i]
        // min(2,3)-1=1
        // min(3,2)-0=2
        //   X
        // XVXVX
        // XXXVXXX
        for (var i = 0; i < height.Length; i++)
        {
            maxLeft = (i - 1) < 0 ? 0 : Math.Max(maxLeft, height[i - 1]);
            maxRight = (i + 1) >= height.Length ? 0 : Max(height, i + 1);
            var volume = Math.Min(maxLeft, maxRight) - height[i];
            if (volume > 0)
            {
                result += volume;
            }
        }

        return result;
    }
    
    private int Max(int[] height, int startPoint)
    {
        var max = 0;
        for (var i = startPoint; i < height.Length; i++)
        {
            if (height[i] > max)
            {
                max = height[i];
            }
        }

        return max;
    }
}
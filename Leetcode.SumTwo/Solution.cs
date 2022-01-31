using System;
namespace Leetcode.SumTwo
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            var cache = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; ++i)
            {
                cache.TryAdd(nums[i], i);
                var secondElement = target - nums[i];
                if (cache.TryGetValue(secondElement, out var index) && index != i)
                {
                    result[0] = index;
                    result[1] = i;
                    return result;
                }
            }
            return result;
        }
    }
}


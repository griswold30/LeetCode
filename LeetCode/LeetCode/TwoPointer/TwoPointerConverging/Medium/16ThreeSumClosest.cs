using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace LeetCode.TwoPointer.TwoPointerConverging.Medium
{
    public static class _ThreeSumClosest
    {
        //O(n^2) Time
        //O(n) space

        public static int ThreeSumClosest(int[] nums, int target)
        {
            var closest = int.MaxValue;
            var closestDelta = int.MaxValue;

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                var low = i + 1;
                var high = nums.Length - 1;
                while (low < high)
                {
                    var sum = nums[i] + nums[low] + nums[high];
                    var delta = Math.Abs(sum - target);
                    if (delta < closestDelta)
                    {
                        closestDelta = delta;
                        closest = sum;
                    }

                    if (delta == 0)
                    {
                        return closest;
                    }
                    if (sum > target)
                    {
                        high--;
                    }
                    if (sum < target)
                    {
                        low++;
                    }
                }
            }

            return closest;
        }
    }
}

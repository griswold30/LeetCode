
using System.Runtime.ExceptionServices;

namespace LeetCode.TwoPointer.InPlaceArrayMutation.Easy
{
    public static class _27RemoveElement
    {
        public static int RemoveElement(int[] nums, int val)
        {
            var i = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }

            return i;
        }
    }
}



namespace LeetCode.TwoPointer.InPlaceArrayMutation.Medium
{
    public static class _80RemoveDuplicatesFromSortedArray2
    {
        public static int RemoveDuplicates(int[] nums)
        {
            var i = 1;
            var count = 1;

            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] == nums[j-1])
                {
                    if (count >= 2)
                    {
                        continue;
                    }

                    count++;
                }
                else
                {
                    count = 1;
                }

                nums[i] = nums[j];
                i++;
            }

            return i;
        }
    }
}

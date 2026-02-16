
namespace LeetCode.TwoPointer.InPlaceArrayMutation.Easy
{
    public static class _26RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            var i = 1;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i-1])
                {
                    nums[i] = nums[j];
                    i++;
                }
            }

            return i;
        }
    }
}

namespace LeetCode.TwoPointer.InPlaceArrayMutation.Easy
{
    public static class _905SortArrayByParity
    {
        public static int[] SortArrayByParity(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left < right)
            {
                if (nums[left] % 2 > nums[right] % 2)
                {
                    var temp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = temp;
                }

                if (nums[left] % 2 == 0) left++;
                if (nums[right] % 2 == 1) right--;
            }

            return nums;
        }
    }
}

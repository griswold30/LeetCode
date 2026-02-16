namespace LeetCode.TwoPointer.InPlaceArrayMutation.Easy
{
    public static class _283MoveZeroes
    {
        public static void MoveZeroes(int[] nums)
        {
            int i = 0;
            for (int j = 0; j < nums.Length && i < nums.Length; j++)
            {
                i = j + 1;
                if (nums[j] == 0)
                {
                    while (i < nums.Length && nums[i] == 0)
                    {
                        i++;
                    }
                    if (i == nums.Length) return;
                    nums[j] = nums[i];
                    nums[i++] = 0;
                }
            }
        }
    }
}

namespace LeetCode.Medium
{
    public static class _2593SumSmaller
    {
        //O(n^2) time
        //O(n) space
        public static int ThreeSumSmaller(int[] nums, int target)
        {
            Array.Sort(nums);
            var tripletCount = 0;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;

                var compliment = target - nums[i];

                while (left < right)
                {

                    if (nums[left] + nums[right] < compliment)
                    {
                        tripletCount += right - left;
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return tripletCount;
        }
    }
}

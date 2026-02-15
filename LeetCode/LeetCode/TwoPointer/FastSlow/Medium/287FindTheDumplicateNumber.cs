
namespace LeetCode.TwoPointer.FastSlow.Medium
{
    public static class _287FindTheDumplicateNumber
    {
        public static int FindDuplicate(int[] nums)
        {

            var tortoise = nums[0];
            var hare = nums[0];

            do
            {
                tortoise = nums[tortoise];
                hare = nums[nums[hare]];
            } while (tortoise != hare);

            tortoise = nums[0];
            while (tortoise != hare)
            {
                tortoise = nums[tortoise];
                hare = nums[hare];
            }

            return hare;
        }
    }
}

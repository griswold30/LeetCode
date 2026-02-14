namespace LeetCode.TwoPointerConverging.Medium
{
    public static class ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int max = 0;

            while (left < right)
            {
                var width = right - left;
                max = Math.Max(max, width * Math.Min(height[left], height[right]));

                if (height[left] >= height[right])
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return max;
        }
    }
}

namespace LeetCode.Easy
{
    public static class _977SquaresOfSortedArray
    {
        //O(N) time
        //O(N) Space
        public static int[] SortedSquares(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;
            var result = new int[nums.Length];

            for (int i = nums.Length -1 ; i >= 0; i--)
            {
                var leftSquare = nums[left] * nums[left];
                var rightSquare = nums[right] * nums[right];

                if (leftSquare > rightSquare)
                {
                    result[i] = leftSquare;
                    left++;
                }
                else
                {
                    result[i] = rightSquare;
                    right--;
                }
            }
            
            return result;
        }
    }
}

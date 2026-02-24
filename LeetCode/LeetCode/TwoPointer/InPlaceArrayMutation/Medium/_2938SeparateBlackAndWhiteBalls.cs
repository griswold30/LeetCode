namespace LeetCode.TwoPointer.InPlaceArrayMutation.Medium
{
    public static class _2938SeparateBlackAndWhiteBalls
    {
        public static long MinimumSteps(string s)
        {
            var whiteInvariantThreshold = 0;
            var totalSteps = 0L;

            for (var i =0; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    totalSteps += (i - whiteInvariantThreshold);
                    whiteInvariantThreshold++;
                }
            }

            return totalSteps;
        }
    }
}

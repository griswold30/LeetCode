namespace LeetCode.SlindingWindow.Medium
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> lastIndexOf = new Dictionary<char, int>();

            int left = 0;
            int maxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                if (lastIndexOf.TryGetValue(s[right], out var index))
                {
                    left = Math.Max(left, index + 1);
                }
                lastIndexOf[s[right]] = right;

                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}

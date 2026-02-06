namespace LeetCode.Easy
{
    public static class TwoSum
    {
        //one-pass
        //O(n) time
        //O(n) space
        public static int[] TwoSumFunc(int[] nums, int target)
        {
            var seen = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var compliment = target - nums[i];
                if (seen.ContainsKey(compliment))
                {
                    return [i, seen[compliment]];
                }

                seen[nums[i]] = i;
            }

            return [];
        }

        //two-pass
        //O(n) time
        //O(n) space
        //public static int[] TwoSumFunc(int[] nums, int target)
        //{
        //    var seen = new Dictionary<int, int>();

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        seen[nums[i]] = i;
        //    }

        //    for (var i = 0; i < nums.Length; i++)
        //    {
        //        var compliment = target - nums[i];
        //        if (seen.ContainsKey(compliment) && seen[compliment] != i)
        //        {
        //            return [i, seen[compliment]];
        //        }
        //    }
        //    return [];
        //}

        //O(n^2) time
        //O(n) space
        //public static int[] TwoSumFunc(int[] nums, int target)
        //{
        //    Dictionary<int, int> seen = new Dictionary<int, int>();

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (seen.TryGetValue(target - nums[i], out var index))
        //        {
        //            return [i, index];
        //        }

        //        for (int j = i+1; j < nums.Length; j++)
        //        {
        //            if (nums[j] == target - nums[i])
        //            {
        //                return [i, j];
        //            }
        //        }

        //        seen.TryAdd(nums[i], i);
        //    }
        //    return [];
        //}
    }
}

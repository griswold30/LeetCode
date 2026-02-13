using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace LeetCode.TwoPointerConverging.Medium
{
    public static class _15ThreeSum
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new HashSet<(int, int, int)>();
            var dupes = new HashSet<int>();
            var seen = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dupes.Contains(nums[i]))
                {
                    dupes.Add(nums[i]);
                    seen.Clear();
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        var compliment = -nums[i] - nums[j];
                        if (seen.Contains(compliment))
                        {
                            var triplet = new List<int> { nums[i], nums[j], compliment };
                            triplet.Sort();
                            result.Add((triplet[0], triplet[1], triplet[2]));
                        }
                        seen.Add(nums[j]);
                    }
                }
            }

            var resultList = new List<IList<int>>();
            foreach (var (num1, num2, num3) in result)
            {
                resultList.Add(new List<int> { num1, num2, num3 });
            }

            return resultList;
        }


        //Time - O(n^2) 
        //Space - O(N)
        public static IList<IList<int>> ThreeSum_TwoSumApproach(int[] nums)
        {
            Array.Sort(nums);
            List<IList<int>> triplets = new List<IList<int>>();

            for (int i = 0; i < nums.Length && nums[i] <= 0; i++)
            {
                if (i > 0 && nums[i - 1] == nums[i]) continue;
                HashSet<int> seen = new HashSet<int>();

                for (int j = i + 1; j < nums.Length; j++)
                {
                    var compliment = -nums[i] - nums[j];
                    if (seen.Contains(compliment))
                    {
                        triplets.Add(new List<int>() { nums[i], nums[j], compliment });
                        while (j + 1 < nums.Length && nums[j] == nums[j + 1]) ++j;
                    }
                    seen.Add(nums[j]);
                }
            }

            return triplets;
        }


        //Time - O(n^2) 
        //Space - O(N)
        public static IList<IList<int>> ThreeSum_TwoSumIIApproach(int[] nums)
        {
            Array.Sort(nums);
            List<IList<int>> triplets = new List<IList<int>>();
            HashSet<int> seen = new HashSet<int>();

            for (int i = 0; i < nums.Length && nums[i] <= 0; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                var low = i+1;
                var high = nums.Length - 1;
                var target = -nums[i];

                while (low < high)
                {
                    var sum = nums[low] + nums[high];
                    if (sum == target)
                    {
                        triplets.Add(new List<int>() { nums[i], nums[low], nums[high] });
                        low++;
                        high--;

                        while (low < high && nums[low] == nums[low - 1]) ++low;
                        while (low < high && nums[high] == nums[high + 1]) --high;
                    }
                    if (sum > target)
                    {
                        --high;
                        while (low < high && nums[high] == nums[high + 1]) high--;
                    }
                    if (sum < target)
                    {
                        ++low;
                        while (low < high && nums[low] == nums[low - 1]) low++;
                    }
                }

                seen.Add(nums[i]);
            }

            return triplets;
        }
    }
}

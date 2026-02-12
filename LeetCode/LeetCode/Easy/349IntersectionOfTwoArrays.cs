namespace LeetCode.Easy
{
    public  class _349IntersectionOfTwoArrays
    {
        //O(n+m) time
        //O(k) space
        public static int[] Intersection_HashLookup(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
            {
                return Intersection_HashLookup(nums2, nums1);
            }
           
            var seen = new HashSet<int>(nums1);
            var added = new HashSet<int>();

            for (int i = 0; i < nums2.Length; i++)
            {
                if (seen.Contains(nums2[i]))
                    added.Add(nums2[i]);
            }

            return added.ToArray();
        }

        //O(n log n + m log m) time
        //O(k) space
        public static int[] Intersection_TwoPointers(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            var result = new HashSet<int>();
            var length1 = nums1.Length;
            var length2 = nums2.Length;

            var p1 = 0;
            var p2 = 0;

            while (p1 < length1 && p2 < length2)
            {
                if (nums1[p1] == nums2[p2])
                {
                    result.Add(nums1[p1]);
                    p1++;
                    p2++;
                }
                else if (nums1[p1] > nums2[p2])
                {
                    p2++;
                }
                else
                {
                    p1++;
                }
            }

            return result.ToArray();
        }
    }
}

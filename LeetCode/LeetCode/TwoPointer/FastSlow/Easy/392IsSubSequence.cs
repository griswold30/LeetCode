using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.TwoPointer.FastSlow.Easy
{
    public static class _392IsSubSequence
    {
        public static bool IsSubsequence(string s, string t)
        {
            int subLimit = s.Length;
            int targetLimit = t.Length;

            int subIndex = 0;
            int targetIndex = 0;

            while (subIndex < subLimit && targetIndex < targetLimit)
            {
                if (s[subIndex] == t[targetIndex])
                {
                    subIndex++;
                }
                targetIndex++;
            }

            return subLimit == subIndex;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.TwoPointer.InPlaceArrayMutation.Medium
{
    public static class _443StringCompression
    {
        public static int Compress(char[] chars)
        {
            var count = 0;
            char last = chars[0];
            int j = 0;
            int i = 0;

            while (i < chars.Length)
            {
                count = 1;
                while (i + count < chars.Length && chars[i + count] == chars[i])
                {
                    count++;
                }
                chars[j++] = chars[i];
                if (count > 1)
                {
                    foreach (var c in count.ToString().ToCharArray())
                    {
                        chars[j++] = c;
                    }
                }

                i += count;
            }
            return j;
        }
    }
}

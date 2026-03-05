namespace LeetCode.GreedyPatterns.IntervalMerging
{
    public class _56MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            List<int[]> merged = new List<int[]>();
            Array.Sort(intervals, (a, b) => a[0] - b[0]);

            for (int i = 0; i < intervals.Length; i++)
            {
                if (merged.Count == 0)
                {
                    merged.Add(new[] { intervals[i][0], intervals[i][1] });
                    continue;
                }

                var lastMerged = merged[^1];

                if (lastMerged[1] < intervals[i][0])
                {
                    merged.Add(new[] { intervals[i][0], intervals[i][1] });
                }
                else
                {
                    lastMerged[1] = Math.Max(lastMerged[1], intervals[i][1]);
                }
            }

            return merged.ToArray();
        }
    }
}

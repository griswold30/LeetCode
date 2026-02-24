
using System.Reflection;

namespace LeetCode.TwoPointer.InPlaceArrayMutation.Medium
{
    public static class _2337MovePiecesToObtainString
    {

        //O(N) Time
        //O(1) Space
        public static bool CanChange(string start, string target)
        {
            var length = start.Length;

            var startIndex = 0;
            var targetIndex = 0;

            while (startIndex < length || targetIndex < length)
            {
                while (startIndex < length && start[startIndex] == '_')
                {
                    startIndex++;
                }

                while (targetIndex < length && target[targetIndex] == '_')
                {
                    targetIndex++;
                }

                if (startIndex == length || targetIndex == length) return startIndex == targetIndex;

                if (start[startIndex] != target[targetIndex] ||
                    (start[startIndex] == 'L' && startIndex < targetIndex) || 
                    (start[startIndex] == 'R' && startIndex > targetIndex)) return false;

                startIndex++;
                targetIndex++;
            }
            return true;
        }

        //O(N) Time
        //O(N) Space
        public static bool CanChangeQueues(string start, string target)
        {
            var targetQueue = new Queue<(char, int)>();
            var startQueue = new Queue<(char, int)>();

            for (var i = 0; i < start.Length; i++)
            {
                if (start[i] != '_') startQueue.Enqueue((start[i], i));
            }

            for (var i = 0; i < target.Length; i++)
            {
                if (target[i] != '_') targetQueue.Enqueue((target[i], i));
            }

            if (startQueue.Count != targetQueue.Count) return false;

            while (targetQueue.Count > 0)
            {
                var startPair = startQueue.Dequeue();
                var targetPair = targetQueue.Dequeue();

                if (startPair.Item1 != targetPair.Item1) return false;
                if (startPair.Item1 == 'L' && startPair.Item2 < targetPair.Item2) return false;
                if (startPair.Item1 == 'R' && startPair.Item2 > targetPair.Item2) return false;
            }

            return true;
        }
    }
}

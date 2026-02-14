namespace LeetCode.TwoPointer.TwoPointerConverging.Medium
{
    public static class TwoSum2
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            var low = 0;
            var high = numbers.Length - 1;

            while (low < high)
            {
                var sum = numbers[low] + numbers[high];
                if (sum == target) return [low + 1, high + 1];
                if (sum < target) low++;
                if (sum > target) high--;
            }

            return [];

        }

        //one pass
        //O(N) Time
        //O(N) Space
        public static int[] TwoSum_OnePass(int[] numbers, int target)
        {

            var seen = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                var compliment = target - numbers[i];

                if (seen.ContainsKey(compliment)) return [seen[compliment] + 1, i + 1];

                seen[numbers[i]] = i;
            }
            return [];
        }

        //TwoPass
        //O(N) Time
        //O(N) Space
        public static int[] TwoSum_TwoPass(int[] numbers, int target)
        {
            var seen = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                seen[numbers[i]] = i;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                var number = numbers[i];
                var compliment = target - number;
                if (seen.ContainsKey(compliment))
                    return [i + 1, seen[compliment] + 1];
            }

            return [];
        }
        
        //NestedLoop
        //O(N^2) Time
        //O(N) Space
        public static int[] TwoSum_BruteForce(int[] numbers, int target)
        {
            var seen = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                var compliment = target - numbers[i];
                if (seen.ContainsKey(compliment))
                    return [i + 1, seen[compliment] + 1];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] == compliment)
                        return [i + 1, j + 1];
                    else
                    {
                        seen[numbers[j]] = j;
                        if (numbers[j] > compliment)
                            break;
                    }
                }
            }
            return [];
        }
    }
}

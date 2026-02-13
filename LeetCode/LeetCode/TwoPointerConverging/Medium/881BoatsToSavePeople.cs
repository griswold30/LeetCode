namespace LeetCode.TwoPointerConverging.Medium
{
    public static class _881BoatsToSavePeople
    {

        //O(N log N) Time
        //O(1) Space
        public static int NumRescueBoatsOptimized(int[] people, int limit)
        {
            var boats = 0;
            var left = 0;
            var right = people.Length - 1;

            Array.Sort(people);

            while (left <= right)
            {
                boats++;

                if (people[left] + people[right] <= limit)
                {
                    left++;
                }

               right--;
            }

            return boats;
        }

        //O(N log N) Time
        //O(1) Space
        public static int NumRescueBoats(int[] people, int limit)
        {
            var boats = 0;
            var left = 0;
            var right = people.Length - 1;

            Array.Sort(people);
            while (right > 0 && people[right] == limit)
            {
                boats++;
                right--;
            }

            while (left <= right)
            {
                boats++;

                if (left == right)
                {
                    break;
                }
                if (people[left] + people[right] <= limit)
                {
                    left++;
                    right--;
                }
                else if (people[left] + people[right] > limit)
                {
                    right--;
                }
            }

            return boats;
        }
    }
}

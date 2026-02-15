namespace LeetCode.TwoPointer.FastSlow.Easy
{
    public static class _202HappyNumber
    {

        //O(log(n))
        //O(1)
        public static bool IsHappy(int n)
        {
            var slow = n;
            var fast = GetNext(n);

            while (fast != 1 && slow != 1 && slow != fast)
            {
                slow = GetNext(n);
                fast = GetNext(GetNext(fast));
            }

            return fast == 1;
        }

        public static int GetNext(int n)
        {
            var sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                n /= 10;
                sum += digit * digit;
            }
            return sum;
        }

        public static bool IsHappyHash(int n)
        {
            var seen = new HashSet<int>();

            while (n != 1)
            {
                var sum = 0;
                seen.Add(n);

                while (n > 0)
                {
                    int digit = n % 10;
                    n /= 10;
                    sum += digit * digit;
                }
                n = sum;
                if (seen.Contains(n)) return false;
            }

            return true;
        }
    }
}

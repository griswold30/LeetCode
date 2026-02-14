using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.TwoPointer.FastSlow.Easy
{
    public static class _141LinkedListCycle
    {
        public class ListNode 
        {
            public int val;
            public ListNode next;
            public ListNode(int x) 
            {
                val = x;
                next = null!;
            }
        }

        //O(N) Time
        //O(1) Space
        public static bool HasCycleFastSlow(ListNode head)
        {
            var slow = head;
            var fast = head.next;

            if (slow is null || fast is null) return false;

            while (slow != fast)
            {
                if (fast == null || fast.next == null) return false;

                slow = slow.next;
                fast = fast.next.next;
            }

            return true;
        }

        //Time - O(N)
        //Space - O(N)
        public static bool HasCycle(ListNode head)
        {
            var seen = new HashSet<ListNode>();

            var current = head;
            while (current != null)
            {
                if (seen.Contains(current)) return true;
                seen.Add(current);
                current = current.next;
            }

            return false;
        }
    }
}

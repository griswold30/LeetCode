using LeetCode.Common;

namespace LeetCode.TwoPointer.FixedSeparation.Medium
{
    public static  class _2095DeleteTheMiddleNodeOfALinkedList
    {
        //O(N) time
        //O(1) space
        public static ListNode DeleteMiddle(ListNode head)
        {
            if (head.next == null) return null;

            var slow = head;
            var fast = slow.next.next;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            slow.next = slow.next.next;

            return head;
        }
    }


}

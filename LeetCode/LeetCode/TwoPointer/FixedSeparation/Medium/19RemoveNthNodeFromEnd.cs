namespace LeetCode.TwoPointer.FixedSeparation.Medium
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static class _19RemoveNthNodeFromEnd
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var dummy = new ListNode();
            dummy.next = head;
            var right = dummy;
            var left = dummy;

            for (int i = 1; i <= n + 1; i++)
            {
                right = right.next;
            }

            while (right != null)
            {
                right = right.next;
                left = left.next;
            }

            left.next = left.next.next;

            return dummy.next;
        }
    }
}

using System.Text;
using LeetCode.Common;


namespace LeetCode.TwoPointer.FixedSeparation.Easy
{
    public static class _876MiddleOfLinkedList
    {
        //O(N) space
        //O(1) Time
        public static ListNode MiddleNode(ListNode head)
        {
            var first = head;
            var second = head;

            while (first != null && first.next != null)
            {
                first = first.next.next;
                second = second.next;
            }

            return second;
        }
    }
}

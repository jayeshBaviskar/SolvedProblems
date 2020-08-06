namespace _19.Remove_Nth_Node_From_End_of_List
{
    /**
  * Definition for singly-linked list.
  * public class ListNode {
  *     public int val;
  *     public ListNode next;
  *     public ListNode(int val=0, ListNode next=null) {
  *         this.val = val;
  *         this.next = next;
  *     }
  * }
  */

    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode slowPtr = head;
            ListNode fastPtr = head;

            for (int i = 0; i < n; i++)
            {
                fastPtr = fastPtr.next;
            }

            if (fastPtr == null)
            {
                return head.next;
            }

            while (fastPtr.next != null)
            {
                slowPtr = slowPtr.next;
                fastPtr = fastPtr.next;
            }

            slowPtr.next = slowPtr.next.next;

            return head;
        }
    }
}
/**
You are given the head of a linked list. Delete the middle node, and return the head of the modified linked list.

The middle node of a linked list of size n is the ⌊n / 2⌋th node from the start using 0-based indexing, where ⌊x⌋ denotes the largest integer less than or equal to x.

    For n = 1, 2, 3, 4, and 5, the middle nodes are 0, 1, 1, 2, and 2, respectively.

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
    public ListNode DeleteMiddle(ListNode head)
    {

        if (head.next == null)
        {
            return head.next;
        }

        ListNode tempHead = new ListNode();
        tempHead = head;
        int mid = (LinkedLength(tempHead) / 2);
        int c = 0;
        bool endFlag = false;
        while (c != mid - 1)
        {
            tempHead = tempHead.next;
            c++;
        }

        ListNode nullHead = tempHead.next;

        if (nullHead != null)
        {
            tempHead.next = nullHead.next;
        }
        else { tempHead.next = null; }

        return head;
    }

    public int LinkedLength(ListNode head)
    {
        int len = 0;
        ListNode node = head;

        while (node != null)
        {
            len++;
            node = node.next;
        }

        return len;
    }
}
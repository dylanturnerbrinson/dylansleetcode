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

/* 19. Remove Nth Node From End of List

Given the head of a linked list, remove the nth node from the end of the list and return its head.

Example 1:

Input: head = [1,2,3,4,5], n = 2
Output: [1,2,3,5]

Example 2:

Input: head = [1], n = 1
Output: []

Example 3:

Input: head = [1,2], n = 1
Output: [1]
*/

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode tempHead = head;
        int i = 0;

        while (tempHead != null){
            tempHead = tempHead.next;
            i++;
        }

        if (i == 1){
            return null;
        }

        ListNode newHead = new();

        //if n == i, set newHead to tempHead.next, aka list[1]. else set to tempHead aka list[0].
        if (i == n){
            head = head.next;
            newHead.val = head.val;
            i--;
        } else {
            newHead.val = head.val;
        }

        ListNode ansHead = newHead;
        head = head.next;
        for (int x = 1; x < i; x++){            
            if (x != i-n){
                newHead.next = new ListNode();
                newHead = newHead.next;
                newHead.val = head.val;
            }
            head = head.next;
        }

        return ansHead;
    }
}
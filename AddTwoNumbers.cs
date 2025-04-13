/**
https://leetcode.com/problems/add-two-numbers/

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
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode l3 = new ListNode();
        ListNode head = l3;

        while (l1 != null && l2 != null){
            int temp_val = l1.val+l2.val+l3.val;

            if (temp_val <= 9){
                l3.val = temp_val;
                if (l1.next != null || l2.next != null){
                    l3.next = new ListNode();
                }
                l3 = l3.next;
            } else {
                l3.val = temp_val-10;
                l3.next = new ListNode();
                l3 = l3.next;
                l3.val = 1;
            }

            if (l1.next == null && l2.next != null){
                l1.val = 0;
                l2 = l2.next;
            } else if (l1.next != null && l2.next == null){
                l2.val = 0;
                l1 = l1.next;
            } else {
                l1 = l1.next;
                l2 = l2.next;
            }
        }

        return head;
    }
}
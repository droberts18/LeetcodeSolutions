/*
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example:

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8
Explanation: 342 + 465 = 807.
*/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummyHead = new ListNode(0);
        ListNode currL1 = l1, currL2 = l2, currAns = dummyHead;

        int carry = 0;

        while(currL1 != null || currL2 != null){
            int val1 = currL1.val;
            int val2 = currL2.val;

            int sum = val1 + val2 + carry;
            carry = sum / 10;

            currAns.next = new ListNode(sum % 10);
            currL1 = currL1.next;
            currL2 = currL2.next;
        }

        // Accounting for a situation in which a new place value needs to be added
        // Ex: 800 + 231 = 1031
        if(carry > 0){
            currAns.next = new ListNode(carry);
        }
        return dummyHead.next;
    }
}
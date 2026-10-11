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
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
         ListNode nextnode = null;
 ListNode previousnode = null;
 ListNode currentnode = head;
 while(currentnode!=null)
 {
     nextnode = currentnode.next;
     currentnode.next = previousnode;

     previousnode = currentnode;
     currentnode = nextnode;
     

 }

 return previousnode;
    }
}

   public class ListNode {
      public int val;
      public ListNode? next;

        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
 }
 
 /// <summary>
 /// Iterative Approach to Reverse a Linked List
 /// Time Complexity: O(n)
 /// Space Complexity: O(1)
 /// </summary>
public class Solution {
    public ListNode? ReverseList(ListNode head) {
        
        ListNode? curr = head; //1
        ListNode? prev = null;
        
        while (curr != null)
        {
            ListNode? next = curr.next; //2
            curr.next = prev; //////////////null
            prev = curr; //1
            curr = next; /////////2
        }
        return prev;
    }
}
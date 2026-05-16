namespace ReverseLinkedList;

/// <summary>
/// Iterative Approach to Reverse a Linked List
/// Time Complexity: O(n)
/// Space Complexity: O(1)
/// </summary>
public class Solution
{
    public ListNode? ReverseList(ListNode head)
    {
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

      public ListNode? ReverseList2(ListNode head)
    {
		// 1,2,3,4
		ListNode? prev = null;
		ListNode? next = head.next; //2
		
        while (head != null)
        {
			//1 -> null
			// 2 -> 1 -> null
			//3 -> 2 -> 1 -> null
			//...
			// 5 -> 4 -> 3 -> 2 -> 1 -> null
			head.next = prev; //null // 1
			prev = head; // 1 //2
			head = next;  // 2 //3
        }
        return head;
    }
}
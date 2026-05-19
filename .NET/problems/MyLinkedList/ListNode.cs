namespace MyLinkedList.App;

public class ListNode {
    public int Val;
    public ListNode Prev;
    public ListNode Next;

    public ListNode(int val) {
        this.Val = val;
        this.Prev = null;
        this.Next = null;
    }
}
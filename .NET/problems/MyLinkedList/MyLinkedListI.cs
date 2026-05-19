namespace MyLinkedList.App;

/// <summary>
/// Time complexity: O(n) for get, addAtIndex and deleteAtIndex. 
/// O(1) for addAtHead and addAtTail
/// </summary>/
public class MyLinkedListI
{
    private ListNode _head;
    private ListNode _tail;
    private int _count = 0;

    public int Get(int index)
    {
        if (_count == 0 || index >= _count || index < 0)
            return -1;

        //First node of the list
        ListNode curr = _head;

        int i = 0;
        while (curr != null)
        {
            if (i == index)
                return curr.Val;

            i++;
            curr = curr.Next;
        }
        return -1;
    }

    public void AddAtHead(int val)
    {
        // If no value, first node to be added
        if (_head == null)
        {
            AtWhenEmpty(val);
            return;
        }

        //The first node, create a new instance for the previous prop and assign a value
        _head.Prev = new ListNode(val);
        _head.Prev.Next = _head;

        //Head poinst to tha new node created
        _head = _head.Prev;
        _count++;
    }

    public void AddAtTail(int val)
    {
        // If no value, first node to be added
        if (_tail == null)
        {
            AtWhenEmpty(val);
            return;
        }

        //The first node, create a new instance for the previous prop and assign a value
        _tail.Next = new ListNode(val);
        _tail.Next.Prev = _tail;

        //Head points to the new node created (last one)
        _tail = _tail.Next;
        _count++;
    }

    public void AddAtIndex(int index, int val)
    {

        if (index > _count || index < 0)
            return;

        // If no value, first node to be added
        if (_head == null || _tail == null)
        {
            AtWhenEmpty(val);
            return;
        }

        if (index == _count)
        {
            //At at the end
            AddAtTail(val);
            return;
        }
        //First node of the list
        ListNode curr = _head;

        int i = 0;
        while (curr != null)
        {
            if (i == index)
            {
                ListNode newNode = new ListNode(val);

                //We point the previous node next pointer to the new node			
                curr.Prev.Next = newNode;
                //We point the new node previous pointer to the previous node of the current one
                newNode.Prev = curr.Prev;
                //We point the new node next node to the current node
                newNode.Next = curr;
                //We point the current node previous pointer to the new node
                curr.Prev = newNode;
                break;
            }

            i++;
            curr = curr.Next;
        }
        _count++;
    }

    public void DeleteAtIndex(int index)
    {
        if (_count == 0 || index >= _count || index < 0)
            return;

        if (_count == 1)
        {
            _head = null;
            _tail = null;
            _count = 0;
            return;
        }

        //First node of the list
        ListNode curr = _head;

        int i = 0;
        while (curr != null)
        {
            if (i == index)
            {
                //if the current node is the first one of the list
                if (curr.Prev == null)
                {
                    curr.Next.Prev = null;
                    _head = curr.Next;
                    break;
                }

                //if the current node is the last one of the list
                if (curr.Next == null)
                {
                    curr.Prev.Next = null;
                    _tail = curr.Prev;
                    break;
                }

                //Node in the middle of the list
                //The node before Next pointer points to the Next node of the current node
                curr.Prev.Next = curr.Next;
                //The Next node Prev pointer points to the Previous node of the current node
                curr.Next.Prev = curr.Prev;
            }

            i++;
            curr = curr.Next;
        }
        _count--;
    }

    private void AtWhenEmpty(int val)
    {
        ListNode newNode = new ListNode(val);
        _head = newNode; // Head points to the first node
        _tail = newNode; // Tail points to the first node
        _count++;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */

//["MyLinkedList",
//"addAtHead",
//"addAtHead",
//"addAtHead",
//"addAtIndex",
//"deleteAtIndex",
//"addAtHead",
//"addAtTail",
//"get",
//"addAtHead",
//"addAtIndex",
//"addAtHead"]
//[[], [7], [2], [1], [3, 0], [2], [6], [4], [4], [4], [5, 0], [6]]
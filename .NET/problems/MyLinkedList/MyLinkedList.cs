//FIrst attempt, continue to work on it
// TODO: Continue working on implementation
public class MyLinkedList
{
    public int? Val;
    public MyLinkedList Next;
    public MyLinkedList Prev;

    private MyLinkedList _temp;
    private MyLinkedList _head;
    private int _count = 0;

    public MyLinkedList(int? val = null, MyLinkedList prev = null, MyLinkedList next = null)
    {
        Val = val;
        Next = next;
        Prev = prev;
        _temp = new MyLinkedList();
    }

    public int Get(int index)
    {
        MyLinkedList curr = _head;
        int i = 0;
        while (curr != null)
        {
            if (i == index)
                return curr.Val;

            i++;
            curr = curr.Next;
        }
    }

    public void AddAtHead(int val)
    {
        if (Val == null)
        {
            Val = val;
            _head = this;
            return;
        }
        else
        {
            Prev = _temp;
            Prev.Val = val;
            Prev.Next = this;
            _head = Prev;
            _temp = Prev.Prev = new MyLinkedList();
        }
        _count++;
    }

    public void AddAtTail(int val)
    {
        _count++;
        if (Val == null)
            Val = val;
        else
        {

        }
    }

    public void AddAtIndex(int index, int val)
    {
        MyLinkedList curr = _head;
        MyLinkedList _tmp;

        int i = 0;
        while (curr != null)
        {
            if (i == index)
            {
                _tmp = curr.Prev;
                curr.Prev = new MyLinkedList();
                curr.Prev.Val = val;
                curr.Prev.Next = curr;
                curr.Prev.Prev = _tmp;
                return;
            }

            i++;
            curr = curr.Next;
        }
        _count++;
    }

    public void DeleteAtIndex(int index)
    {
        MyLinkedList curr = _head;
        MyLinkedList _tmp;

        int i = 0;
        while (curr != null)
        {
            if (i == index)
            {
                curr.Prev.Next = curr.Next;
            }

            i++;
            curr = curr.Next;
        }
        _count--;
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
namespace StackUsingQueues;

//Implementing a Stack using Queues
public class MyStack
{

    private Queue<int> _printQueue;

    public MyStack()
    {
        _printQueue = new Queue<int>();
    }

    public void Push(int x)
    {
        if (_printQueue.Count == 0)
        {
            _printQueue.Enqueue(x);
            return;
        }

        _printQueue.Enqueue(x);

        for (int i = 0; i < _printQueue.Count - 1; i++)
        {
            _printQueue.Enqueue(_printQueue.Dequeue());
        }
    }

    public int Pop()
    {
        return _printQueue.Dequeue();
    }

    public int Top()
    {
        return _printQueue.Peek();
    }

    public bool Empty()
    {
        return _printQueue.Count == 0;
    }
}
//1,2,4,6,7

// [1]
// [] => 1
// [2]
// [2,1]
// [1] => 2
// [1,4]
// [1,4,2]
// [4,2] => 1
// [4,2,1]

// [1,2]
// [2] => 1
// [2,1]
// [2,1,4]
// [1,4] => 2
// [1,4,2]
// [4,2] => 1
// [4,2,1]
// [4,2,1,6]
// [2,1,6] => 4
// [2,1,6,4]
// [1,6,4]

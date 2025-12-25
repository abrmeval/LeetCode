/// <summary>
/// Stack implementation using Stack<T>
/// /// Time Complexity: O(1) for Push, Pop, Top, GetMin
/// Space Complexity: O(n)
/// </summary>
public class MinStack2 {

    private Stack<int> stack;
    private Stack<int> minStack;

    public MinStack2() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }

    public void Push(int val) {
        stack.Push(val);
        val = Math.Min(val, minStack.Count == 0 ? val : minStack.Peek());
        minStack.Push(val);
    }

    public void Pop() {
        stack.Pop();
        minStack.Pop();
    }

    public int Top() {
        return stack.Peek();
    }

    public int GetMin() {
        return minStack.Peek();
    }
}
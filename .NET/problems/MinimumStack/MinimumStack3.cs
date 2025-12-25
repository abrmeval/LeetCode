namespace MinimumStack
{
    /// <summary>
    /// Stack implementation using List<T>
    /// /// Time Complexity: O(1) for Push, Pop, Top, GetMin
    /// Space Complexity: O(n)
    /// </summary>
    public class MinStack3
    {
        private List<int> _stack;
        private List<int> _minStack;
        private int _count;
        public int Count { get => _count; }

        public MinStack3()
        {
            _stack = [];
            _minStack = [];
            // _stack = new List<int>();
            // _minStack = new List<int>();
            _count = 0;
        }

        public void Push(int val)
        {
            _stack.Add(val);
            PushToOrderedStack(val);
            _count++;
        }

        private void PushToOrderedStack(int val)
        {
            if (_count > 0)
            {
                int prev = _minStack[_count - 1];

                if (val < prev)
                {
                    _minStack.Add(val);
                    return;
                }
                _minStack.Add(prev);
                return;
            }

            _minStack.Add(val);
        }

        public void Pop()
        {
            _stack.RemoveAt(_count - 1);
            _minStack.RemoveAt(_count - 1);
            _count--;
        }

        public int Top()
        {
            if (_count > 0)
                return _stack[_count - 1];

            return -1;
        }

        public int GetMin()
        {
            if (_count > 0)
                return _minStack[_count - 1];

            return -1;
        }
    }
}
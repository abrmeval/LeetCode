namespace MinimumStack
{
    /// <summary>
    /// Stack implementation using arrays
    /// /// Time Complexity: O(n) for Push and Pop, O(1) for Top, GetMin
    /// Space Complexity: O(n)
    /// </summary>
    public class MinStack
    {
        private int[] _stack;
        private int[] _minStack;
        private int _count;
        public int Count { get => _count; }

        public MinStack()
        {
            _stack = [];
            _minStack = [];
            //_stack =  new int[]{};
            //_minStack =  new int[]{};
            _count = 0;
        }

        public void Push(int val)
        {
            _stack = [.. _stack, val];
            // _stack = _stack.Append(val).ToArray();
            PushToOrderedStack(val);
            _count++;
        }

        private void PushToOrderedStack(int val)
        {
            _minStack = [.. _minStack, 0];
            // _minStack = _minStack.Append(0).ToArray();

            if (_count > 0)
            {
                int prev = _minStack[_count - 1];

                if (val < prev)
                {
                    _minStack[_count] = val;
                    return;
                }
                _minStack[_count] = prev;
                return;
            }

            _minStack[_count] = val;
        }

        public void Pop()
        {
            _stack = _stack[..^1];
            _minStack = _minStack[..^1];
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
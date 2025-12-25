using MinimumStack;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// ["MinStack", "push", 10, "pop", "push", 20, "top", "push", -20, "getMin"]

MinStack minStack = new MinStack();
minStack.Push(10);
minStack.Pop();
minStack.Push(20);
Console.WriteLine(minStack.Top());  
minStack.Push(-20);
Console.WriteLine(minStack.GetMin()); 

// Console.WriteLine(minStack.GetMin()); // return 0
// minStack.Pop();
// Console.WriteLine(minStack.Top());    // return 2
// Console.WriteLine(minStack.GetMin()); // return 1


MinStack2 minStack2 = new MinStack2();
minStack2.Push(1);
minStack2.Push(2);
minStack2.Push(0);
minStack2.Push(20);

Console.WriteLine(minStack2.GetMin()); // return 0
minStack2.Pop();
Console.WriteLine(minStack2.Top());    // return 2
Console.WriteLine(minStack2.GetMin()); // return 1
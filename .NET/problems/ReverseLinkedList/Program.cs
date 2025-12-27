// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

ListNode listNode = new ListNode(1);
listNode.next = new ListNode(2);
listNode.next.next = new ListNode(3);
listNode.next.next.next = new ListNode(4);

Solution solution = new Solution();
solution.ReverseList(listNode);

// Solution2 solution2 = new Solution2();
// solution2.ReverseList(listNode);
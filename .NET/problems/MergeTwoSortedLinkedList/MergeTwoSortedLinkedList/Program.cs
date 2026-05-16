Console.WriteLine("Hello, World!");

Solution solution = new Solution();

ListNode list1 = new ListNode(1);
list1.next = new ListNode(2);
list1.next.next = new ListNode(4);

ListNode list2 = new ListNode(1);
list2.next = new ListNode(3);
list2.next.next = new ListNode(4);

var mergedList = solution.MergeTwoLists(list1, list2);

using MyLinkedList.App;
Console.WriteLine("Hello, World!");

MyLinkedListI myLinkedList = new MyLinkedListI();
myLinkedList.AddAtHead(7);
myLinkedList.AddAtHead(2);
myLinkedList.AddAtHead(1);
myLinkedList.AddAtIndex(3, 0);    // linked list becomes 1->2->3
myLinkedList.DeleteAtIndex(2);    // now the linked list is 1->3
myLinkedList.AddAtHead(6);
myLinkedList.AddAtTail(4);
             // return 2
var n = myLinkedList.Get(4);               // return 3
Console.WriteLine(n);
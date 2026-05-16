public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    /// <summary>
    /// Time complexity: O(n + m) where n and m are the lengths of the two lists
    /// </summary>
    /// <param name="list1"></param>
    /// <param name="list2"></param>
    /// <returns></returns>
    public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        ListNode? list3 = new();
        ListNode? next = list3;

        if (list1 == null)
            return list2;

        if (list2 == null)
            return list1;

        while (true)
        {
            if (list2 == null)
            {
                next.val = list1.val;
                list1 = list1.next;
            }
            else if (list1 == null)
            {
                next.val = list2.val;
                list2 = list2.next;
            }
            else if (list1.val > list2.val)
            {
                next.val = list2.val;
                list2 = list2.next;
            }
            else
            {
                next.val = list1.val;
                list1 = list1.next;
            }          

            if (list1 == null && list2 == null)
                break;

            next = next.next = new();
        }

        return list3;
    }

    /// <summary>
    /// Recursive Solution
    /// Time Complexity: O(n + m) where n and m are the lengths of the two lists
    /// </summary>
    /// <param name="list1"></param>
    /// <param name="list2"></param>
    /// <returns></returns>
    public ListNode? MergeTwoLists2(ListNode? list1, ListNode? list2)
    {
        if (list1 == null)
            return list2;

        if (list2 == null)
            return list1;


        if (list1.val < list2.val)
        {
            list1.next = MergeTwoLists2(list1.next, list2);
            return list1;
        }
        else
        {
            list2.next = MergeTwoLists2(list1, list2.next);
            return list2;
        }         
    }
}
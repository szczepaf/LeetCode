public class Solution{
     public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if(list1 == null && list2 == null) return null;
        if (list1 == null) return list2;
        if(list2 == null) return list1;
         
         
        ListNode start = new ListNode();

        if (list1.val >= list2.val)
        {
            start = list2;
            list2 = list2.next;
        }
        else
        { 
            start = list1;
            list1 = list1.next;
        }
        ListNode current = start;

        while(list1 != null && list2 != null)
        {
            if (list1.val > list2.val)
            {
                current.next = list2;
                current = list2;
                list2 = list2.next;
            }
            else if(list1.val <= list2.val) 
            {
                current.next = list1;
                current = list1;
                list1 = list1.next;
            }
            

        }

        while(list1 != null)
        {
            current.next = list1;
            current = list1;  
            list1 = list1.next;
        }
        while (list2 != null)
        {
            current.next = list2;
            current = list2;
            list2 = list2.next;
        }
    return start;

    }
}

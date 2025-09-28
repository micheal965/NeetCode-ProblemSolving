namespace Problem_Solving.NeetCode.Day_13
{
    internal class MergeLinkedLists
    {
        //Program program = new Program();
        ////ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        //ListNode list1 = new ListNode();
        //ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(5)));
        //program.MergeTwoLists(list1, list2);


        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode head = new ListNode(0), curr;
            curr = head;
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    curr.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    curr.next = list2;
                    list2 = list2.next;
                }
                curr = curr.next;
            }
            if (list1 != null)
                curr.next = list1;
            else
                curr.next = list2;

            return head.next;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}

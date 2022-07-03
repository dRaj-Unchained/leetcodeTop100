using System;

namespace _21_MergeTwoSortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode llst = new ListNode(1);
            ListNode head = llst;
            llst = new ListNode(2);
            head.next = llst;
            llst = new ListNode(4);
            head.next.next = llst;
            //llst = new ListNode(7);
            //head.next.next.next = llst;
            //llst = new ListNode(9);
            //head.next.next.next.next = llst;

            ListNode llst2 = new ListNode(1);
            ListNode head2 = llst2;
            llst2 = new ListNode(3);
            head2.next = llst2;
            llst2 = new ListNode(4);
            head2.next.next = llst2;
            //llst2 = new ListNode(8);
            //head2.next.next.next = llst2;
            //llst2 = new ListNode(10);
            //head2.next.next.next.next = llst2;


            ListNode re = MergeTwoLists(head, head2);
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
                return list2;
            if (list2 == null)
                return list1;
            ListNode prv = list1;
            ListNode mergedhead = prv;
            bool isfirst = true;
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    prv = list1;
                    list1 = list1.next;
                }
                else if (isfirst)
                {

                    mergedhead = list2;
                    list2 = list2.next;
                    mergedhead.next = list1;
                    prv = mergedhead;
                }
                else {
                    ListNode tp = list2;
                    list2 = list2.next;
                    tp.next = list1;
                    prv.next = tp;
                    prv = prv.next;
                }
                isfirst = false;

            }
            if (list1 != null) {
                prv.next = list1;
            }
            if (list2 != null)
                prv.next = list2;
            return mergedhead;
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
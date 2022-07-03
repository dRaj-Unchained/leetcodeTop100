using System;

namespace _23_MergekSortedLists
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

            ListNode llst2 = new ListNode(-1);
            ListNode head2 = llst2;
            llst2 = new ListNode(5);
            head2.next = llst2;
            llst2 = new ListNode(11);
            head2.next.next = llst2;
            //llst2 = new ListNode(8);
            //head2.next.next.next = llst2;
            //llst2 = new ListNode(10);
            //head2.next.next.next.next = llst2;

            ListNode llst3 = new ListNode(1);
            ListNode head3 = llst3;
            llst3 = new ListNode(3);
            head3.next = llst3;
            llst3 = new ListNode(4);
            head3.next.next = llst3;
            //llst3 = new ListNode(8);
            //head3.next.next.next = llst3;
            //llst3 = new ListNode(10);
            //head3.next.next.next.next = llst3;

            ListNode llst4 = new ListNode(6);
            ListNode head4 = llst4;
            llst4 = new ListNode(10);
            head4.next = llst4;
            //llst4 = new ListNode(4);
            //head4.next.next = llst4;
            //llst4 = new ListNode(8);
            //head4.next.next.next = llst4;
            //llst4 = new ListNode(10);
            //head4.next.next.next.next = llst4;

            ListNode[] inp = new ListNode[] { null, head2, null, head4 };
            ListNode re = MergeKLists(inp);
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
        }

        public static ListNode MergeKLists(ListNode[] lists)
        {
            ListNode mergedhead = null;
            ListNode prv = null;
            if (lists.Length == 1)
                return lists[0];
            for (int i = 0; i < lists.Length ; i++)
            {
                ListNode list1 = i==0? lists[i]:mergedhead;
                ListNode list2 = i == 0 ? lists[i + 1]: lists[i];

                if (i==0 && list1 == null)
                {
                    mergedhead = list2;
                    i++;
                    continue;
                }
                if (i == 0 && list2 == null)
                {
                    mergedhead = list1;
                    continue;
                    i++;

                }
                if (list2 == null)
                    continue;
                prv = list1;
                mergedhead = prv;
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
                    else
                    {
                        ListNode tp = list2;
                        list2 = list2.next;
                        tp.next = list1;
                        prv.next = tp;
                        prv = prv.next;
                    }
                    isfirst = false;

                }
                if (list1 != null && prv!=null)
                {
                    prv.next = list1;
                }
                if (list2 != null && prv != null)
                    prv.next = list2;
                if (i == 0)
                    i++;
            }

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

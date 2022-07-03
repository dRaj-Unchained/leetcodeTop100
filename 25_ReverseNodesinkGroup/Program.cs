using System;

namespace _25_ReverseNodesinkGroup
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
            llst = new ListNode(7);
            head.next.next.next = llst;
            llst = new ListNode(9);
            head.next.next.next.next = llst;

            ListNode r = ReverseKGroup(head,2);
        }

        public static ListNode ReverseKGroup(ListNode head,int k)
        {

            ListNode mainhead = head;
            ListNode prevNode = null;
            ListNode prevhead= null;
            ListNode list = head;
            while(list != null)
            {
                ListNode checklength = list;
                int lenght = 1;
                while (checklength.next != null) {
                    lenght++;
                    if (lenght == k)
                        break;
                    checklength = checklength.next;
                }
                if (lenght != k)
                    break;
                int counter = 0;
                while (list != null)
                {

                    //ListNode n1 = list;
                    ListNode n2 = list.next;
                    list.next = prevNode;
                    if (counter == 0)
                        prevhead = list;
                    prevNode = list;
                    list = n2;
                    counter++;
                    if (counter == k)
                        break;
                }
                mainhead = prevNode;
                prevhead.next = list;

            }
            return mainhead;
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

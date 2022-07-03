using System;

namespace SwapNodesPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode llst = new ListNode(1);
            ListNode head = llst;
            llst = new ListNode(2);
            head.next = llst;
            llst = new ListNode(3);
            head.next.next = llst;
            llst = new ListNode(4);
            head.next.next.next = llst;
            llst = new ListNode(5);
            head.next.next.next.next = llst;

            ListNode re = SwapPairs(head);
            Console.WriteLine("Hello World!");
        }
        public static ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
                return head;


            ListNode headclone = head;
            ListNode prev = head;
            bool first = true;
            while (headclone!=null && headclone.next != null  )
            {
                ListNode temp = headclone.next;
                if (first)
                {
                    head = temp;
                    first = false;
                    headclone.next = headclone.next.next;
                    temp.next = headclone;
                    //prev.next = temp;
                    prev = headclone;
                    headclone = headclone.next;
                }
                else {
                    temp = headclone.next;
                    headclone.next = headclone.next.next;
                    temp.next = headclone;
                    prev.next = temp;
                    prev = headclone;
                    headclone = headclone.next;
                }
               

            }
            return head;
        }
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

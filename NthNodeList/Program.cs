using System;

namespace NthNodeList
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

            ListNode re = RemoveNthFromEnd(head, 2);
            Console.WriteLine("Hello World!");
        }

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode temp = head;
            int count = 1;
            while (temp.next != null) {
                temp = temp.next;
                count++;
            }
            count -= n;
            if (count == 0) {
                head = head.next;
                return head;
            }
            temp = head;
            while (count != 1) {
                temp= temp.next;
                count--;
            }
            temp.next = temp.next.next;
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

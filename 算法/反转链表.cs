using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Reverse a singly linked list
 * Example:
 * Input:1->2->3->4->5->null
 * Output:5->4->3->2->1->null
 * Follow up
 * A linked list can be reversed either iteratively or
 * recursively. Could you implement both?
 */
namespace ConsoleApp12
{
    /*
     * Definition for singly-linked list
     * public class ListNode
     * {
     *      public int val;
     *      public ListNode next;
     *      public ListNode(int x) {val = x;}
     * }
     */
     public class ListNode
     {
     public int val;
     public ListNode next;
     public ListNode(int x) { val = x; }
    
}
public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode currentNode = head;
            ListNode newNode = null;
            while(currentNode!=null)
            {
                ListNode tempNode = currentNode.next;
                currentNode.next = newNode;
                newNode = currentNode;
                currentNode = tempNode;
            }

            return newNode;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

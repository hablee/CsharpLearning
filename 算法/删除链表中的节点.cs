using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /*Write a function to delete a node(except the tail)
     * in a singly linked list, given only access to that node.
     * Example1:
     * Input: head=[4,5,1,9], node=5
     * Output:[4,1,9]
     * 
     * Note:
     * The linked list will have at least two elements
     * All of the nodes' values will be unique
     * The given node will not be the tail and it will always be a valid
     * node of the linked list
     * Do not return anything from your function
     * 
     */
     public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class Solution
    {
        public void DeleteNode(ListNode node)
        {
            //给我们的node就是链表的一部分，直接在上面操作就可以了
            ListNode temp = node.next;
            while(temp!=null)
            {
                node.val = temp.val;
                temp = temp.next;
                if(temp!=null)
                {
                    node = node.next;
                }
            }
            node.next = null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

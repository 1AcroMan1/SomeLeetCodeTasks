using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeSolutions.MergeTwoSortedLists;

namespace LeetCodeSolutions
{
    internal class RemoveDublicatesFromSortedList
    {
        public void DeleteNodeDublicates(ListNode node)
        {
            if (node == null) return;
            while(node.next != null&& node.val == node.next.val)
                node.next = node.next.next;
            DeleteDuplicates(node.next);
        }
        public ListNode DeleteDuplicates(ListNode head)
        {
            DeleteNodeDublicates(head);
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

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodes
{
    /*
    class Palindromic
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            ListNode nodes = new ListNode(1221);
            Console.WriteLine(sol.IsPalindrome(nodes)); 
        }       
    }

  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }

    public class Solution
    {
        public bool IsPalindrome(ListNode head)
        {
            string headToStr = head.val.ToString();
            string reversedHead = null;
            char[] arr = headToStr.ToCharArray();
            for (int i = arr.Length-1; i>=0; i--)
            {
                reversedHead = reversedHead + arr[i];
            }
            if(headToStr == reversedHead)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    */
}

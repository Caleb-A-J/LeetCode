using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LeetCode
{
    public class ListNode
    {
        public ListNode next;
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return false; // no cycle if head or next is null
            }

            ListNode slow = head;
            ListNode fast = head.next;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    return true; // cycle detected
                }
            }

            return false; // no cycle found
        }
    }
}

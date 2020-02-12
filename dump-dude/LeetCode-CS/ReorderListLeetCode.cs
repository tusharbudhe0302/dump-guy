using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    public class ListNodeLeet
    {
        public int val;
        public ListNodeLeet next;
        public ListNodeLeet(int x) { val = x; }
    }
    class ReorderListLeetCode
    {
        public ListNodeLeet ReorderList(ListNodeLeet head)
        {
            // Step 1: Tortoise and hare method to get middle point
            ListNodeLeet slow = head, fast = head.next;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            // Step 2:  Split List
            // node1, head of first half 1-> 2-> 3
            // node2, head of second half 4 -> 5 
            ListNodeLeet node1 = slow;
            ListNodeLeet node2 = slow.next;
            // Step 3: Reverse Second half 5->4
            node2 = reverseList(node2);
            // Step 4: Merge in result
            ListNodeLeet temp = new ListNodeLeet(0);
            ListNodeLeet current = temp;
            while(node1!=null && node2 != null)
            {
                if(node1 != null)
                {
                    current.next = node1;
                    node1 = node1.next;
                    current = current.next;
                }
                if (node2 != null)
                {
                    current.next = node2;
                    node2 = node2.next;
                    current = current.next;
                }
            }
            return temp.next;

        }

        private ListNodeLeet reverseList(ListNodeLeet node2)
        {
            ListNodeLeet p, prev = null, next;
            p = node2;
            while (p != null)
            {
                next = p.next;
                p.next = prev;
                prev = p;
                p = next;
            }
            return prev;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    class ArrayTwoNumber
    {
        public Node start;
        private Node resultAdd;

        internal Node ResultAdd { get => resultAdd; set => resultAdd = value; }

        public ArrayTwoNumber()
        {
            start = null;
        }

        public List<int> AddNumbers()
        {
            List<int> lstOne = new List<int>();
            List<int> lstTwo = new List<int>();
            List<int> result = new List<int>();
            lstOne.Add(5);
            lstOne.Add(1);
            lstOne.Add(1);
            lstTwo.Add(9);
            lstTwo.Add(2);
            lstTwo.Add(1);
            int count = lstOne.Count;
            int carry = 0, lastDigit = 0;
            for (int i = 0; i < count; i++)
            {
                int sum = lstOne[i] + lstTwo[i];
                if (carry > 0)
                    sum = sum + carry;
                if (sum >= 10)
                {
                    carry = 1;
                    lastDigit = sum % 10;
                    result.Add(lastDigit);
                }
                else
                {
                    carry = 0;
                    result.Add(sum);
                }

            }
            result.Reverse();
            if (result.Count > 0)
                return result;
            else
                return null;

        }
        #region Please refer link list code
        public Node AddItemToList(int i)
        {
            Node temp = new Node(i);
            Node p;
            if (start == null)
            {
                temp.link = start;
                start = temp;
                return start;
            }
            p = start;
            while (p.link != null)
            {
                p = p.link;
            }
            p.link = temp;
            return start;
        }
        public Node AddItemAtBeginningOfList(int item)
        {
            Node temp = new Node(item);
            if (start == null)
            {
                temp.link = start;
                start = temp;
                return start;
            }
            temp.link = start;
            start = temp;
            return start;
        }
        #endregion
        //        You are given two non-empty linked lists representing two non-negative integers.The digits are stored in reverse order and each of their nodes contain a single digit.Add the two numbers and return it as a linked list.

        //You may assume the two numbers do not contain any leading zero, except the number 0 itself.

        //Example:

        //Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        //Output: 7 -> 0 -> 8
        //Explanation: 342 + 465 = 807.
        public ListNode AddNumberNoGenrics(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);
            ListNode current = result;
            int p, q, sum = 0, carry = 0;
            while (l1 != null || l2 != null)
            {
                p = (l1 != null) ? l1.val : 0;
                q = (l2 != null) ? l2.val : 0;
                sum = p + q + carry;
                if (sum >= 10)
                {
                    carry = 1;
                    current.next = new ListNode(sum % 10);
                }
                else
                {
                    carry = 0;
                    current.next = new ListNode(sum);
                }
                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;
                current = current.next;
            }

            if (carry > 0)
            {
                current.next = new ListNode(carry);
            }
            return result.next;
        }

        private void Reverse()
        {
            Node next, p, prev = null;
            p = start;
            while (p.link != null)
            {
                next = prev;
                prev = p;
                p = p.link;
                p.link = next;
            }
            start = prev;
        }
    }
}

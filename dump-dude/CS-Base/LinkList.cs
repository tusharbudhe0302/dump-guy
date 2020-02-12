using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace next_gen
{
    internal class SingleLinkList
    {
        NodeLink p, start;
        public SingleLinkList()
        {
            start = null;
        }
        internal void DisplayList()
        {
            if (CheckEmptyList())
            {
                return;
            }
            p = start;
            Console.Write("Items into list :");
            while (p != null)
            {
                Console.Write(p.data + " ");
                p = p.link;
            }
            Console.WriteLine("");
        }
        public bool CheckEmptyList()
        {
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return true;
            }
            return false;
        }
        internal int DisplayListCount()
        {
            int count = 0;
            if (CheckEmptyList())
            {
                return count;
            }
            p = start;
            while (p.link != null)
            {
                count++;
                p = p.link;
            }
            int finalCount = count++;
            Console.WriteLine("Count :" + finalCount);
            return finalCount;
        }
        internal void SearchItemIntoList(int item)
        {
            throw new NotImplementedException();
        }
        internal void InsertAtBeginning(int item)
        {
            NodeLink temp = new NodeLink(item);
            temp.link = start;
            start = temp;

        }
        internal void InsertAtEnd(int item)
        {
            NodeLink temp = new NodeLink(item);
            if (start == null)
            {
                temp.link = start;
                start = temp;
                return;
            }
            p = start;
            while (p.link != null)
            {
                p = p.link;
            }
            p.link = temp;
        }
        internal void InsertAfterNode(int itemCheckInsertAfterNode, int item)
        {
            p = start;
            while (p != null)
            {
                if (Convert.ToInt32(p.data) == itemCheckInsertAfterNode)
                {
                    break;
                }
                p = p.link;
            }

            if (p.data != null && p.link == null)
            {
                InsertAtEnd(item);
                return;
            }
            else
            {
                if (p.link == null)
                {
                    Console.WriteLine("No item foruns in list!");
                    return;
                }
                NodeLink temp = new NodeLink(item);
                temp.link = p.link;
                p.link = temp;
            }

        }
        internal void InsertBeforeNode(int itemBeforeNode, int item)
        {
            p = start;
            while (p != null)
            {
                if (Convert.ToInt32(p.link.data) == itemBeforeNode)
                {
                    break;
                }
                p = p.link;
            }
            if (p.link == null)
            {
                Console.WriteLine("No item foruns in list!");
                return;
            }
            NodeLink temp = new NodeLink(item);
            temp.link = p.link;
            p.link = temp;
        }
        internal void InsertAtPosition(int position, int item)
        {
            int listCount = DisplayListCount();
            if (listCount <= position)
            {
                int k = 0;
                p = start;
                while (p.link != null)
                {
                    k++;
                    if (k == position)
                    {
                        break;
                    }
                    p = p.link;
                }
                if (p.link == null)
                {
                    InsertAtEnd(item);
                    return;
                }
                NodeLink temp = new NodeLink(item);
                temp.link = p.link;
                p.link = temp;
            }
            else
            {
                Console.WriteLine("You can insert till position " + listCount);
            }
        }
        internal void DeleteFirstNode()
        {
            p = start;
            start = p.link;
        }
        internal void DeleteLastNode()
        {
            p = start;
            while (p.link != null)
            {
                p = p.link;
            }
            p.link = null;
        }
        internal void DeleteOnlyNode(int deleteatposition)
        {
            if (deleteatposition == 0)
                start = null;
            else
            {
                int position = 0;
                p = start;
                while (p.link != null)
                {
                    position++;
                    if (position == deleteatposition)
                    {
                        break;
                    }
                    p = p.link;
                }
                p.link = p.link.link;
            }

        }
        internal void ReverseList()
        {
            NodeLink prev, next;
            prev = null;
            p = start;
            while (p != null)
            {
                next = p.link;
                p.link = prev;
                prev = p;
                p = next;
            }
            start = prev;
        }
        internal void CreateList()
        {
            Console.WriteLine("Please enter list count you want ?");
            int Count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine("Please Enter item you want to insert");
                int item = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(item);
            }
        }
        internal void CheckCyle(int cycleItem = 0)
        {
            Console.WriteLine("Check Cycle");
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            NodeLink slowPointer = start, fastPointer = start;
            int count = 0;
            while (fastPointer != null && fastPointer.link != null)
            {
                slowPointer = slowPointer.link;
                fastPointer = fastPointer.link.link;
                count++;
                if (slowPointer == fastPointer)
                {
                    Console.WriteLine("List has cycle as first point met to other pointer" + slowPointer.data);
                    if (cycleItem == 1)
                    {
                        Console.WriteLine("You can write code to insert NodeLink here");
                    }
                    else if (cycleItem == 2)
                    {
                        Console.WriteLine("You can write code to delete NodeLink here");
                    }
                    else if (cycleItem == 3)
                    {
                        Console.WriteLine("You can write code to udpate NodeLink here");
                    }
                    return;
                }
            }
            Console.WriteLine("List Don't have cycle");
            Console.WriteLine("Create Cycle mually for testing");
            start.link.link.link = start.link;
            CheckCyle();
        }
        internal void MergeSort()
        {
            Random random = new Random();
            int listOneCount = random.Next(5, 8);
            int listTwoCount = random.Next(3, 5);
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            Console.WriteLine("List 1 items: ");
            for (int i = 0; i < listOneCount; i++)
            {
                int currentItem = random.Next(i, listOneCount);
                Console.Write(currentItem + " ");
                list1.Add(currentItem);
            }
            Console.WriteLine();
            Console.WriteLine("List 2 items: ");
            for (int i = 0; i < listTwoCount; i++)
            {
                int currentItem = random.Next(i, listTwoCount);
                Console.Write(currentItem + " ");
                list2.Add(currentItem);
            }
            list1.Sort();
            Console.WriteLine();
            Console.WriteLine("List 1 Sorted items: ");
            list1.ForEach(PrintList);
            list2.Sort();
            Console.WriteLine();
            Console.WriteLine("List 2 Sorted items: ");
            list2.ForEach(PrintList);
            var mergeListConcat = list1.Concat(list2).ToList();
            Console.WriteLine();
            Console.WriteLine("Merge list, concatination linque opertation of list1 & list2 items: ");
            mergeListConcat.ForEach(PrintList);
            mergeListConcat.Sort();
            Console.WriteLine();
            Console.WriteLine("Merge concat list sorted items: ");
            mergeListConcat.ForEach(PrintList);
            var mergeListUnion = list1.Union(list2).ToList();
            Console.WriteLine();
            Console.WriteLine("Merge list, union linque opertation of list1 & list2 items: ");
            mergeListUnion.ForEach(delegate (int number)
            {
                Console.Write(number + " ");
            });
            Console.WriteLine();
            Console.WriteLine("Merge union list sorted items: ");
            mergeListUnion.Sort();
            mergeListUnion.ForEach(delegate (int number)
            {
                Console.Write(number + " ");
            });
            Console.WriteLine();
            Console.WriteLine("Recurrsive Merge Sort items list1 only: ");
            List<int> gameObject1 = list1.GetRange(0, list1.Count / 2);
            List<int> gameObject2 = list1.GetRange(0, list1.Count / 2);
            /*Split list and sort then merge with sort*/
        }
        private static void PrintList(int s)
        {
            Console.Write(s + " ");
        }
        internal void BubbleSortListAddressOrLinkExcahnge()
        {
            NodeLink q, end, temp, r;
            for (end = null; end != start.link; end = p)
            {
                for (r = p = start; p.link != end; p = p.link)
                {
                    q = p.link;
                    if (Convert.ToInt32(p.data) > Convert.ToInt32(q.data))
                    {
                        p.link = q.link;
                        q.link = p;
                        if (p != start)
                        {
                            r.link = q;
                        }
                        else
                        {
                            start = q;

                        }
                        temp = p;
                        p = q;
                        q = temp;
                    }
                }
            }
        }
        public NodeLink reverseListRecursive(NodeLink x)
        {
            if (x == null || x.link == null) return x;
            NodeLink temp = reverseListRecursive(x.link);
            x.link.link = x;
            x.link = null;
            return temp;

        }
        internal void BubbleSortListData()
        {
            NodeLink q, end;
            for (end = null; end != start.link; end = p)
            {
                for (p = start; p.link != end; p = p.link)
                {
                    q = p.link;
                    if (Convert.ToInt32(p.data) > Convert.ToInt32(q.data))
                    {
                        int temp = Convert.ToInt32(p.data);
                        p.data = q.data;
                        q.data = temp;

                    }
                }
            }

        }
    }
    internal class DoubleLinkList
    {
        DoubleNodeLink start, p;
        public DoubleLinkList()
        {
            start = null;
        }
        internal void DisplayList()
        {
            if (start == null)
            {
                Console.WriteLine("List is empty!");
                return;
            }
            p = start;
            Console.WriteLine("Your item in list");
            while (p.next != null)
            {
                PrintList(Convert.ToInt32(p.data));
                p = p.next;
            }
            Console.WriteLine();
        }
        private static void PrintList(int s)
        {
            Console.Write(s + " ");
        }
        internal void CreateItemAtBeginnning(int item)
        {
            DoubleNodeLink temp = new DoubleNodeLink(item);
            if (start == null)
            {
                start = temp;
                return;
            }

            temp.next = start;
            start.prev = temp;
            start = temp;

            return;
        }
        internal void CreateItemAtEnd(int item)
        {
            DoubleNodeLink temp = new DoubleNodeLink(item);
            if (start == null)
            {
                start = temp;
                return;
            }
            p = start;
            while (p.next != null)
            {
                p = p.next;
            }
            p.next = temp;
            temp.prev = p;
        }
        internal void CreateItemAtPosition()
        {
            throw new NotImplementedException();
        }
        internal void CreateItemAftertPosition()
        {
            throw new NotImplementedException();
        }
        internal void CreateList()
        {
            Console.WriteLine("Please enter count fo list");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Please enter item ");
                int item = Convert.ToInt32(Console.ReadLine());
                CreateItemAtEnd(item);
            }
        }
    }
}

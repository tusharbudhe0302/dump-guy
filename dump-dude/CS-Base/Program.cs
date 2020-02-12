using next_gen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Base
{
    class Program
    {
        private static int choice;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
            SingleLinkList list = new SingleLinkList();
            DoubleLinkList doubleList = new DoubleLinkList();
            BinarySearchTree bst = new BinarySearchTree();
            int item;
            bool singlelinklist = false;
            bool doublelinklist = false;
            bool searchingAlgo = false;
            bool sortingAlgo = false;
            bool recursiveAlgo = false;
            bool bstAlgo = false;
            while (singlelinklist)
            {
                Console.WriteLine();
                Console.WriteLine("----Please Select Options-------");
                Console.WriteLine("1. Dislpay List");
                Console.WriteLine("2. Count number of NodeLink in list");
                Console.WriteLine("3. SearchingAlgorithum for an element");
                Console.WriteLine("4. Insert into emplty list / Beginning of list");
                Console.WriteLine("5. Insert NodeLink at end of list");
                Console.WriteLine("6. Insert NodeLink after specified NodeLink");
                Console.WriteLine("7. Insert NodeLink before specified NodeLink");
                Console.WriteLine("8. Insert NodeLink at given k-th position");
                Console.WriteLine("9. Delete first NodeLink");
                Console.WriteLine("10. Delete any specific NodeLink");
                Console.WriteLine("11.Delete last NodeLink ");
                Console.WriteLine("12. Reverse of the list");
                Console.WriteLine("13. Bubble sort by exchanging the data");
                Console.WriteLine("14. Bubble sort by exchanging the link");
                Console.WriteLine("15. Merge sort");
                Console.WriteLine("16. Insert cycle");
                Console.WriteLine("17. Delete cycle");
                Console.WriteLine("18. Remove cycle");
                Console.WriteLine("19. Create list");
                Console.WriteLine("20. Reverse List Recursive");
                Console.WriteLine("21. Quit");
                Console.WriteLine("Please Enter Your Choice :");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 21)
                {
                    Console.WriteLine("Program End........");
                    break;
                }
                switch (choice)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        list.DisplayListCount();
                        break;
                    case 3:
                        Console.WriteLine("Please enter item you want to SearchingAlgorithum into list");
                        item = Convert.ToInt32(Console.ReadLine());
                        list.SearchItemIntoList(item);
                        break;
                    case 4:
                        Console.WriteLine("Please enter item you want to insert beginning of list");
                        item = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtBeginning(item);
                        break;
                    case 5:
                        Console.WriteLine("Please enter item you want to insert end of the list");
                        item = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(item);
                        break;
                    case 6:
                        list.DisplayList();
                        int itemAfterNode;
                        Console.WriteLine("Please enter item you want to insert after item");
                        itemAfterNode = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter item you want to insert into list");
                        item = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfterNode(itemAfterNode, item);
                        break;
                    case 7:
                        list.DisplayList();
                        int itemBeforeNode;
                        Console.WriteLine("Please enter item you want to insert before item");
                        itemBeforeNode = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter item you want to insert into list");
                        item = Convert.ToInt32(Console.ReadLine());
                        list.InsertBeforeNode(itemBeforeNode, item);
                        break;
                    case 8:
                        int position;
                        Console.WriteLine("Please enter position you want to insert item.");
                        position = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter item you want to insert into list");
                        item = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtPosition(position, item);
                        break;
                    case 9:
                        list.DeleteFirstNode();
                        break;
                    case 10:
                        list.DeleteLastNode();
                        break;
                    case 11:
                        int deleteatposition;
                        Console.WriteLine("Please enter position you want to delete from list. Please enter 0 if you want to make list as empty.");
                        deleteatposition = Convert.ToInt32(Console.ReadLine());
                        list.DeleteOnlyNode(deleteatposition);
                        break;
                    case 12:
                        list.ReverseList();
                        break;
                    case 13:
                        list.BubbleSortListData();
                        break;
                    case 14:
                        list.BubbleSortListAddressOrLinkExcahnge();
                        break;
                    case 15:
                        list.MergeSort();
                        break;
                    case 16:
                        list.CreateList();
                        list.CheckCyle(1);
                        break;
                    case 17:
                        list.CreateList();
                        list.CheckCyle(2);
                        break;
                    case 18:
                        list.CreateList();
                        list.CheckCyle(3);
                        break;
                    case 19:
                        list.CreateList();
                        break;
                    case 20:
                        NodeLink root = new NodeLink(5);
                        root.link = new NodeLink(7);
                        root.link.link = new NodeLink(9);
                        NodeLink res = list.reverseListRecursive(root);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            while (doublelinklist)
            {
                Console.WriteLine("----Please Select Options-------");
                Console.WriteLine("Please Enter Your Choice :");
                Console.WriteLine("1. DisplayList");
                Console.WriteLine("2. CreateItemAtEnd");
                Console.WriteLine("3. CreateItemAtBeginnning");
                Console.WriteLine("4. CreateItemAtPosition");
                Console.WriteLine("5. CreateItemAftertPosition");
                Console.WriteLine("6. DeleteFirstItem");
                Console.WriteLine("7. DeleteItemOnPosition");
                Console.WriteLine("8. UpdateItemOnPosition");
                Console.WriteLine("9. DeleteItemOnPosition");
                Console.WriteLine("10. CreateList");

                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your Choice : " + choice);
                if (choice == 11)
                {
                    Console.WriteLine("Program End........");
                    break;
                }
                switch (choice)
                {
                    case 1:
                        doubleList.DisplayList();
                        break;
                    case 2:
                        Console.WriteLine("Please Enter Item");
                        item = Convert.ToInt32(Console.ReadLine());
                        doubleList.CreateItemAtEnd(item);
                        break;
                    case 3:
                        Console.WriteLine("Please Enter Item");
                        item = Convert.ToInt32(Console.ReadLine());
                        doubleList.CreateItemAtBeginnning(item);
                        break;
                    case 4:
                        doubleList.CreateItemAtPosition();
                        break;
                    case 5:
                        doubleList.CreateItemAftertPosition();
                        break;
                    //case 6:
                    // doubleList.DeleteFirstItem();
                    // break;
                    //case 7:
                    // doubleList.DeleteItemOnPosition();
                    // break;
                    //case 8:
                    // doubleList.UpdateItemOnPosition();
                    // break;
                    //case 9:
                    // doubleList.DeleteItemOnPosition();
                    // break;
                    case 10:
                        doubleList.CreateList();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            while (searchingAlgo)
            {
                Console.WriteLine("----Please Select Options-------");
                Console.WriteLine("0. Quit");
                Console.WriteLine("1. Liner SearchingAlgorithum");
                Console.WriteLine("2. Binary SearchingAlgorithum");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your Choice : " + choice);
                SearchingAlgorithum SearchingAlgorithum = new SearchingAlgorithum();
                if (choice == 0)
                {
                    Console.WriteLine("Program End........");
                    return;
                }
                switch (choice)
                {
                    case 1:
                        SearchingAlgorithum.LinearSearch();
                        break;
                    case 2:
                        SearchingAlgorithum.BinarySearch();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            while (sortingAlgo)
            {
                Console.WriteLine("***********************");
                Console.WriteLine("0. Quit");
                Console.WriteLine("1. Create Dummy Data ");
                Console.WriteLine("2. Create Data Using Your Choice");
                Console.WriteLine("3. Selection Sort");
                Console.WriteLine("4. Bubble Cort");
                Console.WriteLine("5. Insertion Sort");
                Console.WriteLine("6. Recursive Merge Sort");
                Console.WriteLine("7. Iterative Merge Sort ");
                Console.WriteLine("8. Quick Sort ");
                Console.WriteLine("9. Binary Tree Sort ");
                Console.WriteLine("10. Heap Sort ");
                Console.WriteLine("11. Redix Sort ");
                Console.WriteLine("12. Address Calculation Sort ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                {
                    Console.WriteLine("Program End..");
                    return;
                }

                switch (choice)
                {
                    case 3:
                        SortingAlgorithm sort = new SortingAlgorithm();
                        sort.SelectionSort();
                        break;
                    case 6:
                        SortingAlgorithm recursiveMergesort = new SortingAlgorithm();
                        recursiveMergesort.MergeSort();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                Console.WriteLine();
            }
            while (recursiveAlgo)
            {
                Console.WriteLine("***********************");
                Console.WriteLine("0. Quit");
                Console.WriteLine("1. Create Dummy Data ");
                Console.WriteLine("2. Create Data Using Your Choice");
                Console.WriteLine("3. Selection Sort");
                Console.WriteLine("4. Bubble Cort");
                Console.WriteLine("5. Insertion Sort");
                Console.WriteLine("6. Recursive Merge Sort");
                Console.WriteLine("7. Iterative Merge Sort ");
                Console.WriteLine("8. Quick Sort ");
                Console.WriteLine("9. Binary Tree Sort ");
                Console.WriteLine("10. Heap Sort ");
                Console.WriteLine("11. Redix Sort ");
                Console.WriteLine("12. Address Calculation Sort ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                {
                    Console.WriteLine("Program End..");
                    return;
                }

                switch (choice)
                {
                    case 3:
                        SortingAlgorithm sort = new SortingAlgorithm();
                        sort.SelectionSort();
                        break;
                    case 6:
                        SortingAlgorithm recursiveMergesort = new SortingAlgorithm();
                        recursiveMergesort.MergeSort();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                Console.WriteLine();
            }
            while (bstAlgo)
            {
                Console.WriteLine("************************");
                Console.WriteLine("Please Enter your choice :");
                Console.WriteLine("1. Create default Binary tree");
                Console.WriteLine("2. Create int Binary tree");
                Console.WriteLine("3. Display BST");
                Console.WriteLine("4. Min Node Value");
                Console.WriteLine("5. Max Node Value");
                Console.WriteLine("6. Height Of Tree ");
                Console.WriteLine("7. Insert Into BST ");
                Console.WriteLine("8. Insert Into BST Iterator ");
                Console.WriteLine("9. Delete Item From BST ");
                Console.WriteLine("0. Quit");
                int Choice = Convert.ToInt32(Console.ReadLine());
                if (Choice == 0)
                {
                    Console.WriteLine("Program end ...");
                    return;
                }

                switch (Choice)
                {
                    case 1:
                        bst.CreateTree();
                        break;
                    case 2:
                        bst.createIntTree();
                        break;
                    case 3:
                        bst.DisplayTree();
                        break;
                    case 4:
                        bst.DisplayMin();
                        break;
                    case 5:
                        bst.DisplayMax();
                        break;
                    case 6:
                        int heightOfTree = bst.DisplayHeight();
                        Console.WriteLine("Height Of Tree : " + heightOfTree);
                        break;
                    case 7:
                        Console.WriteLine("Please Enter Number you would like to insert into tree");
                        int item7 = Convert.ToInt32(Console.ReadLine());
                        bst.InsertItem(item7);
                        break;
                    case 8:
                        Console.WriteLine("Please Enter Number you would like to insert into tree");
                        int item0 = Convert.ToInt32(Console.ReadLine());
                        bst.InsertItemI(item0);
                        break;
                    case 9:
                        Console.WriteLine("Please Enter Number you would like to delete into tree");
                        int itemDelete = Convert.ToInt32(Console.ReadLine());
                        bst.DeleteItem(itemDelete);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }
            Console.ReadLine();
        }
    }
}

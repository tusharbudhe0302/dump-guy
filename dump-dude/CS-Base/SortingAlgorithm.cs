using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace next_gen
{
    class SortingAlgorithm
    {
        int[] a = new int[5];
        public SortingAlgorithm()
        {
            a[0] = 15;
            a[1] = 10;
            a[2] = 7;
            a[3] = 23;
            a[4] = 1;
        }
        /*
        * UnSordted : 15 10 4 23 1
        * j =1 ; minIndex= 0 :
        *
        * Sorted : 1 4 10 15 23
        */
        public void SelectionSort()
        {
            DisplayArray(a);
            int minIndex, temp, i, j;
            int n = a.Length;
            for (i = 0; i < n; i++)
            {
                minIndex = i;
                for (j = i + 1; j < n; j++)
                {
                    Console.WriteLine("minIndex = " + minIndex + " Value : " + a[minIndex]);
                    if (a[j] < a[minIndex])
                    {
                        minIndex = j;
                    }
                    if (i != minIndex)
                    {
                        temp = a[i];
                        a[i] = a[minIndex];
                        a[minIndex] = temp;
                    }
                    Console.WriteLine("Loop J = " + j);
                    DisplayArray(a);
                }
                Console.WriteLine("Loop I = " + i);
                DisplayArray(a);
            }
            Console.WriteLine();
        }
        private void DisplayArray(int[] a)
        {
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public void MergeSort()
        {
            List<int> unSortedList = new List<int>();
            Random rndm = new Random();
            Console.Write("UnSorted Array items : ");
            /*for (int i = 0; i<10; i++)
            {
            int curentNumber = rndm.Next(i,20);
            Console.Write(curentNumber + " ");
            unSortedList.Add(curentNumber);
            }*/
            List<int> SortedList = new List<int>();
            unSortedList.Add(13);
            unSortedList.Add(17);
            unSortedList.Add(7);
            unSortedList.Add(8);
            unSortedList.Add(17);
            unSortedList.Add(6);
            unSortedList.Add(12);
            unSortedList.Add(8);
            unSortedList.Add(16);
            unSortedList.Add(18);
            Console.WriteLine("UnSorted Array: ");
            DisplayList(unSortedList);
            SortedList = MergeSplit(unSortedList);
            Console.WriteLine("Sorted Array: ");
            DisplayList(SortedList);
        }
        public static List<int> MergeSplit(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }
            /*
            * For debugging
            */
            if (left.Count > 0)
            {
                Console.WriteLine("Left Items : ");
                DisplayList(left);
            }
            left = MergeSplit(left);
            /*
            * For debugging
            */
            if (right.Count > 0)
            {
                Console.WriteLine("Right Items : ");
                DisplayList(right);
            }
            right = MergeSplit(right);
            Console.WriteLine("Sorting Start Here ");
            Console.WriteLine("Sorting Start Here Left ");
            DisplayList(left);
            Console.WriteLine("Sorting Start Here Right ");
            DisplayList(right);
            return SortedMerge(left, right);
            //return unsorted;
        }
        private static void DisplayList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
        public static List<int> SortedMerge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {

                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }

            return result;
        }
    }
}

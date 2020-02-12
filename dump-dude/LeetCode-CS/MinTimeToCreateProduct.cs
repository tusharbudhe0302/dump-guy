using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    //    Minimum time required to produce m items
    //Consider n machines which produce same type of items but at different rate
    //i.e., machine 1 takes a1 sec to produce an item, machine 2 takes a2 sec to produce an item.
    //        Given an array which contains the time required by ith machine to produce an item.
    //        Considering all machine are working simultaneously, the task is to find minimum time required to produce m items.

    //Examples:

    //Input : arr[] = {1, 2, 3}, m = 11
    //Output : 6
    //In 6 sec, machine 1 produces 6 items, machine 2 produces 3 items,
    //and machine 3 produces 2 items.So to produce 11 items minimum
    //6 sec are required.

    //Input : arr[] = {5, 6}, m = 11
    //Output : 30
    class MinTimeToCreateProduct
    {
        public int minTime(int[] arr, int n, int m)
        {

            // Intialise time, items equal to 0. 
            int t = 0;

            while (true)
            {
                int items = 0;

                // Calculating items at each second 
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("current time :" + t + "current element :" + arr[i] + "current ietm :" + t / arr[i]);
                    items += (t / arr[i]);
                    if (items >= m)
                        return t;

                    t++;
                }
                // If items equal to m return time. 
                // Increment time 
            }
        }
    }

}
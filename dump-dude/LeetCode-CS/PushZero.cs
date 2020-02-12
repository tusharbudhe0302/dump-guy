using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    class PushZero
    {
        static void pushZerosToEnd(int[] arr, int n)
        {
            // Count of non-zero elements 
            int count = 0;

            // Traverse the array. If element encountered is 
            // non-zero, then replace the element  
            // at index â..countâ.. with this element 
            for (int i = 0; i < n; i++)
                if (arr[i] != 0)

                    // here count is incremented 
                    arr[count++] = arr[i];

            // Now all non-zero elements have been shifted to 
            // front and â..countâ.. is set as index of first 0. 
            // Make all elements 0 from count to end. 
            while (count < n)
                arr[count++] = 0;
        }

        // Driver function  
        //public static void Main()
        //{
        //    int[] arr = { 1, 9, 8, 4, 0, 0, 2, 7, 0, 6, 0, 9 };
        //    int n = arr.Length;
        //    pushZerosToEnd(arr, n);
        //    Console.WriteLine("Array after pushing all zeros to the back: ");
        //    for (int i = 0; i < n; i++)
        //        Console.Write(arr[i] + " ");
        //}
    }
}

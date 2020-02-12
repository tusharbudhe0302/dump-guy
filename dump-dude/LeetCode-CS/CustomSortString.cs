using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    class CustomSortString
    {
        public string customSortStringLiner(string S, string T)
        {
            // Step 1: Get Chars Frequency For Each T
            // Step 2 : Scan String S and Print Number of Char in T
            // Step 3 : Scan Frequency again and append anything Non Zero
            // Time Complexity O(n)
            //S and T are strings composed of lowercase letters. In S, no letter occurs more than once.
            // S was sorted in some custom order previously. We want to permute the characters of T so that they match the order that S was sorted. More specifically, if x occurs before y in S, then x should occur before y in the returned string.
             //Return any permutation of T(as a string) that satisfies this property.
            //Example :
            //Input:
            //S = "cba"
            //T = "abcd"
            //Output: "cbad"
            //Explanation:
            //            "a", "b", "c" appear in S, so the order of "a", "b", "c" should be "c", "b", and "a".
            //            Since "d" does not appear in S, it can be at any position in T. "dcba", "cdba", "cbda" are also valid outputs.
            //Note:
            // S has length at most 26, and no character is repeated in S.
            //T has length at most 200.
            //S and T consist of lowercase letters only.
            int[] frequency = new int[26];
            foreach (char ch in T.ToCharArray())
            {
                frequency[ch - 'a']++;
            }
            StringBuilder sb = new StringBuilder();
            foreach (char ch in S.ToCharArray())
            {
                while (frequency[ch - 'a'] > 0)
                {
                    sb.Append(ch);
                    frequency[ch - 'a']--;
                }
            }
            for (int i = 0; i < frequency.Length; i++)
            {
                while (frequency[i] > 0)
                {
                    sb.Append((char)(i + 'a'));
                    frequency[i]--;
                }
            }
            return sb.ToString();
        }
        public string customSortStringMergeSort(string S, string T)
        {
            int[] distinct = new int[26];

            for (int i = 0; i < S.ToCharArray().Length; i++)
            {
                distinct[S[i] - 'a'] = i;
            }
            char[] Aux = new char[T.Length];
            char[] A = T.ToCharArray();
            customMergeSort(distinct, A, Aux, 0, A.Length - 1);
            StringBuilder newSb = new StringBuilder();
            foreach (char chResult in A)
            {
                newSb.Append(chResult);
            }
            return newSb.ToString();
        }
        private void customMergeSort(int[] distinct, char[] a, char[] aux, int low, int high)
        {
            if (low >= high)
            {
                return;
            }
            int mid = low + (high - low) / 2;
            customMergeSort(distinct, a, aux, low, mid);
            customMergeSort(distinct, a, aux, mid + 1, high);
            customMerge(distinct, a, aux, low, mid, high);
        }
        private void customMerge(int[] dict, char[] A, char[] Aux, int lo, int mid, int hi)
        {

            for (int l = lo; l <= hi; l++)
            {
                Aux[l] = A[l];
            }
            int i = lo;
            int j = mid + 1;


            for (int k = lo; k <= hi; k++)
            {
                if (i > mid)
                {
                    A[k] = Aux[j++];
                }
                else if (j > hi)
                {
                    A[k] = Aux[i++];
                }
                else if (dict[Aux[i] - 'a'] < dict[Aux[j] - 'a'])
                {
                    A[k] = Aux[i++]; ;
                }
                else if (dict[Aux[i] - 'a'] >= dict[Aux[j] - 'a'])
                {
                    A[k] = Aux[j++];
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    // In an alien language, surprisingly they also use english lowercase letters, but possibly in a different order.The order of the alphabet is some permutation of lowercase letters.
    //Given a sequence of words written in the alien language, and the order of the alphabet, return true if and only if the given words are sorted lexicographicaly in this alien language.
    //Example 1:
    //Input: words = ["hello", "leetcode"], order = "hlabcdefgijkmnopqrstuvwxyz"
    //Output: true
    //Explanation: As 'h' comes before 'l' in this language, then the sequence is sorted.

    //Example 2:
    //Input: words = ["word", "world", "row"], order = "worldabcefghijkmnpqstuvxyz"
    //Output: false
    //Explanation: As 'd' comes after 'l' in this language, then words[0] > words[1], hence the sequence is unsorted.

    //Example 3:
    //Input: words = ["apple", "app"], order = "abcdefghijklmnopqrstuvwxyz"
    //Output: false
    //Explanation: The first three characters "app" match, and the second string is shorter (in size.) According to lexicographical rules "apple" > "app", because 'l' > '∅', where '∅' is defined as the blank character which is less than any other character (More info).
    class VerifyingAlienDictionary
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        public bool IsAlienSorted(string[] words, string order)
        {
            char[] orderCharList = order.ToCharArray();

            int k = 0;
            foreach (char ch in orderCharList)
            {
                map.Add(ch, k++);
            }
            for (int i = 0; i < words.Length - 1; i++)
            {
                string firstWord = words[i];
                string secondWord = words[i + 1];
                if (!rankCheck(firstWord, secondWord)) return false;
            }
            return true;
        }
        public bool rankCheck(string firstWord, string secondWord)
        {

            for (int j = 0; j < firstWord.Length; j++)
            {
                if (j >= secondWord.Length) return false;
                char char1 = firstWord[j];
                char char2 = secondWord[j];
                Console.WriteLine(char1 + " " + char2);
                int rank1 = map[char1];
                int rank2 = map[char2];
                if (rank1 > rank2) return false;
                else if (rank1 == rank2)
                    continue;
                else return true;
            }
            return true;
        }
    }

}

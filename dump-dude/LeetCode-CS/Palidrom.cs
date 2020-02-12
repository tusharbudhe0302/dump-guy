using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    class Palindrome
    {
        public static void PrintPalidrom(string s)
        {
            char[] ip = s.ToCharArray();
            Array.Reverse(ip);
            string reverse = new string(ip);
            bool isPalindrome = reverse.Equals(s, StringComparison.OrdinalIgnoreCase);
            if (isPalindrome)
            {
                Console.WriteLine(s + " is Palindrome.");
                return;
            }
            else
            {
                Console.WriteLine(s + " is  not Palindrome.");
            }
        }
        public bool ValidPalindromeSubmittedLeetCode(string s)
        {
            char[] ip = s.ToCharArray();
            Array.Reverse(ip);
            string reverse = new string(ip);
            bool isPalindrome = reverse.Equals(s, StringComparison.OrdinalIgnoreCase);
            if (isPalindrome)
            {
                Console.WriteLine(s + " is Palindrome.");
                return true;
            }
            else
            {
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    string convertToValidPalidrome = s;
                    string checkPlaidrom = convertToValidPalidrome.Remove(i, 1);
                    char[] ip2 = checkPlaidrom.ToCharArray();
                    Array.Reverse(ip2);
                    string reverse2 = new string(ip2);
                    bool isPalindrome2 = reverse2.Equals(checkPlaidrom, StringComparison.OrdinalIgnoreCase);
                    if (isPalindrome2)
                    {
                        Console.WriteLine(checkPlaidrom + " is Palindrome.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine(checkPlaidrom + " is  not Palindrome.");
                        continue;
                    }
                }
                Console.WriteLine(s + " is  not Palindrome.");
            }
            return isPalindrome;
        }
        List<string> validPalindrome = new List<string>();
        public List<string> ValidPalindromeSubmittedLeetCodeRecursive(string s)
        {
            char[] ip = s.ToCharArray();
            Array.Reverse(ip);
            string reverse = new string(ip);
            bool isPalindrome = reverse.Equals(s, StringComparison.OrdinalIgnoreCase);
            if (isPalindrome)
            {
                if (!validPalindrome.Contains(s))
                    validPalindrome.Add(s);
                //   Console.WriteLine(s + " is Palindrome.");
                //     return true;
            }
            else
            {
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    string convertToValidPalidrome = s;
                    string checkPlaidrom = convertToValidPalidrome.Remove(i, 1);
                    ValidPalindromeSubmittedLeetCodeRecursive(checkPlaidrom);
                }
                Console.WriteLine(s + " is  not Palindrome.");
            }
            return validPalindrome;
        }
    }

}

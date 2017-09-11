using System;

namespace StringPalindrome.LngPalindromicSubStr
{
    class BruteForce
    {
        static void Main(string[] args)
        {
            LngPalindromicSubStr.BruteForce.LongestPalindrome("google");
            
            Console.WriteLine("\n\nPlease press any key to exit...");
            Console.ReadKey();
        }

        internal static void LongestPalindrome(string str)
        {
            var n = str.Length; // length of the given string
            var maxLen = 0; // to hold the max length of palindromic sub strings for processing
            string longestPalindrome = null; // to hold the max length palindromic sub string

            // Two outer loops are to form the combinations of all possible sub strings in the given string

            for (int i = 0; i < n; i++) // Outer loop 1 - start index of sub string
            {
                for (int j = i; j < n; j++) // Outer loop 2 - end index of sub string
                {
                    var subStr = str.Substring(i, j - i + 1); // length of the sub string      

                    // IsPalindromeString(subStr) have an inner loop to indentify palindrome sub string
                    if (IsPalindromeString(subStr) && maxLen < subStr.Length) // check if the substring is palindrome and is of the max length till now
                    {
                        maxLen = subStr.Length; // take a copy of current max length
                        longestPalindrome = subStr; // take a copy of max length sub string
                    }
                }
            }

            // Print the result
            Console.WriteLine(longestPalindrome);
        }

        internal static bool IsPalindromeString(string str)
        {
            // Flag to indicate whether the given string is palindrome or not
            bool isPalindrome = true;

            // Left index and right index variables
            int l, r;

            // initialize with respective values
            l = 0; r = str.Length - 1;

            // This loop will run n/2 times where n is the length of the given string
            while (l <= r)
            {
                if (str[l] == str[r])
                {
                    // Moving left index to right by step 1
                    l++;
                    // Moving right index to left by step 1
                    r--;
                }
                else
                {
                    // Identified a char difference
                    isPalindrome = false;
                    break;
                }
            }

            // Return the outcome as boolean
            return isPalindrome;
        }
    }
}

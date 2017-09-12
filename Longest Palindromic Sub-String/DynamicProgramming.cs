using System;

namespace StringPalindrome.LngPalindromicSubStr
{
    class DynamicProgramming
    {
        static void Main(string[] args)
        {
            LongestPalindrome("google");

            Console.WriteLine("\n\nPlease press any key to exit...");
            Console.ReadKey();
        }

        // This function prints the longest palindrome substring
        // of str[].
        // It also returns the length of the longest palindrome
        private static void LongestPalindrome(string str)
        {
            var n = str.Length; // get length of input string

            // table[i][j] will be false if substring str[i..j]
            // is not palindrome.
            // Else table[i][j] will be true
            var table = new bool[n,n];

            #region palindromic sub string of length 1

            int maxLength = 1; // to hold the max length of palindromic sub string

            // All substrings of length 1 are palindromes
            for (int i = 0; i < n; i++)
            {
                table[i, i] = true;
            }

            #endregion

            #region palindromic sub string of length 2

            // check for sub-string of length 2.
            int start = 0;
            for (int i = 0; i < n - 1; ++i)
            {
                if (str[i] == str[i + 1])
                {
                    table[i,i + 1] = true;
                    start = i;
                    maxLength = 2;
                }
            }

            #endregion

            #region palindromic sub string of length greater than 2

            // Check for lengths greater than 2. k is length
            // of substring
            for (int k = 3; k <= n; ++k)
            {

                // Fix the starting index
                for (int i = 0; i < n - k + 1; ++i)
                {
                    // Get the ending index of substring from
                    // starting index i and length k
                    int j = i + k - 1;

                    // checking for sub-string from ith index to
                    // jth index iff str.charAt(i+1) to 
                    // str.charAt(j-1) is a palindrome
                    if (table[i + 1, j - 1] && str[i] == str[j])
                    {
                        table[i, j] = true;

                        if (k > maxLength)
                        {
                            start = i;
                            maxLength = k;
                        }
                    }
                }
            }

            #endregion

            #region print the result

            Console.Write("   ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(str[i] + "  ");
            }
            Console.WriteLine("\n");

            for (int i=0;i< n; i++)
            {
                Console.Write(str[i] + "  ");
                for(int j=0;j< n; j++)
                {
                    Console.Write((table[i, j] ? 1 : 0) + "  ");
                }
                Console.Write("\n\n");
            }

            Console.WriteLine("\nLongest palindrome (Length:" + maxLength + ") substring is: " + str.Substring(start, start + maxLength));

            #endregion
        }
    }
}

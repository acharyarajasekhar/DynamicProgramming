using System;

namespace StringPalindrome.EggDrop
{
    class Recursive
    {
        static void Main(string[] args)
        {
            var n = 3;
            var k = 9;

            var res = Drops(n, k);
            Console.WriteLine("No.Of Eggs: " + n + ", No.Of Floors: " + k + ", Min Drops: " + res);

            Console.WriteLine("\n\nPlease press any key to exit...");
            Console.ReadKey();
        }

        private static int Drops(int n, int k)
        {
            var noOfDrops = new int[n + 1, k + 1];

            // If no.of eggs are 0, then with any no.of floors the result is 0
            // If no.of eggs are 1, then the result is equal to k (current floor)
            for (int i = 0; i <= k; i++)
            {
                noOfDrops[0, i] = 0;
                noOfDrops[1, i] = i;
            }

            // If floors are 0, with any number of eggs the result is 0
            for (int j = 0; j <= n; j++)
            {
                noOfDrops[j, 0] = 0;
            }

            for (int i = 2; i <= n; i++) // loop through the no.of eggs
            {
                for (int j = 1; j <= k; j++) // loop through the no.of floors
                {
                    int min = Int32.MaxValue; // Set the max number

                    for (int x = 1; x <= j; x++) // Actual formula that calculates the required value
                    {
                        min = Math.Min(min, (1 + Math.Max(noOfDrops[i, j - x], noOfDrops[i - 1, x - 1])));
                    }

                    noOfDrops[i, j] = min; // Assign the result to the current position
                }
            }

            // Print the memoization matrix
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= k; j++)
                {
                    Console.Write(noOfDrops[i, j] + " ");
                }
                Console.WriteLine();
            }

            // return the result
            return noOfDrops[n, k];
        }
    }
}

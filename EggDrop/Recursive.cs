using System;

namespace StringPalindrome.EggDrop
{
    class Recursive
    {
        static void Main(string[] args)
        {
            var n = 2;
            var k = 20;
            var res = Drops(n, k);
            Console.WriteLine("No.Of Eggs: " + n + ", No.Of Floors: " + k + ", Min Drops: " + res);

            Console.WriteLine("\n\nPlease press any key to exit...");
            Console.ReadKey();
        }

        private static int Drops(int n, int k)
        {
            if (n == 1) return k;
            if (k == 0) return k;
            if (k == 1) return k;

            int min = Int32.MaxValue;

            for (int i = 2; i <= k; i++)
            {
                min = Math.Min(min, (1 + Math.Max(Drops(n, k-i), Drops(n-1, i-1))));
            }

            return min;
        }
    }
}

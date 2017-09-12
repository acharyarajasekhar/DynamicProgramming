using System;

namespace FibonacciSeries
{
    class DynamicProgramming
    {
        static void Main(string[] args)
        {
            var n = 9;
            var res = Fib(n);
            Console.Write("Fib of " + n + " is: " + res);

            Console.WriteLine("\n\nPlease press any key to exit...");
            Console.ReadKey();
        }

        private static int Fib(int n)
        {
            // an array of n + 1 to hold the fibonacci numbers
            var f = new int[n + 1];

            f[0] = 0; // f(0) = 0
            f[1] = 1; // f(1) = 1

            for (int i = 2; i <= n; i++)
            {
                f[i] = f[i - 1] + f[i - 2]; // f(i) = f(i-1) + f(i-2)
            }

            // This is a bottom up approach wich will avoid repeated calculations performce in case of recursive approach

            return f[n]; // return the final result
        }
    }
}

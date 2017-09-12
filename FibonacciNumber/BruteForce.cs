using System;

namespace FibonacciSeries
{
    class BruteForce
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
            if (n <= 1) // F(0) = 0 and F(1) = 1
                return n;
            return Fib(n - 1) + Fib(n - 2); // If n > 1 then F(n) = F(n-1) + F(n-2)
        }
    }
}

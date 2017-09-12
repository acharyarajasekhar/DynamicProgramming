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
            var temp = 0; // to hold the current fibonacci number
            var f = new int[2]; // two memory locations to hold recent two fibonacci numbers
            
            f[0] = 0; f[1] = 1; // Init f(0) = 0 and f(1) = 1

            for(int i = 2; i <= n; i++)
            {
                temp = f[1] + f[0]; // Calc current fib number by adding latest two numbers from array
                f[0] = f[1]; // move f(1) to f(0)
                f[1] = temp; // move temp to f(1)
            }

            return f[1]; // return the final result
        }
    }
}

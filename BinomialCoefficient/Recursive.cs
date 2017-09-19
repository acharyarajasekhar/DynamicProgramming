using System;

class Program
{
    static void Main(string[] args)
    {
        var n = 5;
        var k = 2;

        var res = BinomialCoeff(n, k);
        Console.WriteLine("Binomial Coefficient C( " + n + "," + k + ") is : " + res);

        Console.WriteLine("\n\nPlease press any key to exit...");
        Console.ReadKey();
    }

    // Returns value of Binomial Coefficient C(n, k)
    private static int BinomialCoeff(int n, int k)
    {
        // Base Cases
        if (k == 0 || k == n)
            return 1;

        // Recur
        return BinomialCoeff(n - 1, k - 1) + BinomialCoeff(n - 1, k);
    }
}

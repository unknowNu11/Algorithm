using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        int numOfPrimes = 0;

        for (int i = 0; i < N; i++)
        {
            int n = int.Parse(input[i]);
            if (n <= 1) continue;
            if (n == 2) { numOfPrimes++; continue; }
            if (n % 2 == 0) continue;

            bool isPrime = true;
            int root = (int)Math.Sqrt(n);

            for (int j = 3; j <= root; j += 2)
            {
                if (n % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime) numOfPrimes++;
        }

        Console.WriteLine(numOfPrimes);
    }
}

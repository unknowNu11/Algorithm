using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        BigInteger num1 = BigInteger.Parse(input[0]);
        BigInteger num2 = BigInteger.Parse(input[1]);

        BigInteger multiply = num1 * num2;
        Console.WriteLine(multiply);
    }
}

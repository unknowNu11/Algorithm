using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        // BigInteger 흠..
        BigInteger input1 = BigInteger.Parse(Console.ReadLine());
        BigInteger input2 = BigInteger.Parse(Console.ReadLine());
        
        Console.WriteLine((input1 + input2));
        Console.WriteLine((input1 - input2));
        Console.WriteLine((input1 * input2));
    }
}
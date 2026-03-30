using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        
        for (int i = 0; i < int.Parse(input); ++i)
        {
            string inputNumber = Console.ReadLine();
            
            // 비트연산 and, 우선순위 고려하여 & 먼저 계산, == 보다 먼저
            if( (BigInteger.Parse(inputNumber) & 1) == 0)
                Console.WriteLine("even");
            else
                Console.WriteLine("odd");
        }
    }
}
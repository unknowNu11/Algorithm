using System;

class Program
{
    static void Main()
    {
        string[] input;
        int a, b, c;

        input = Console.ReadLine().Split();

        a = int.Parse(input[0]);
        b = int.Parse(input[1]);
        c = int.Parse(input[2]);

        Console.WriteLine((a + b) % c);
        Console.WriteLine(((a % c) + (b % c)) % c);
        Console.WriteLine((a * b) % c);
        Console.WriteLine(((a % c) * (b % c)) % c);
    }
}
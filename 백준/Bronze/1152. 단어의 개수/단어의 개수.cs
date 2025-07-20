using System;

class Program
{
    static void Main()
    {
        int word = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        Console.WriteLine(word);
    }
}
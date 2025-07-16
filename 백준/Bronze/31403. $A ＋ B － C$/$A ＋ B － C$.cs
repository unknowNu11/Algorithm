using System;

class Program
{
    static void Main()
    {
        string inputA = Console.ReadLine();
        string inputB = Console.ReadLine();
        string inputC = Console.ReadLine();
        
        Console.WriteLine(int.Parse(inputA) + int.Parse(inputB) - int.Parse(inputC));
        Console.WriteLine(int.Parse($"{inputA}{inputB}") - int.Parse(inputC));
    }
}
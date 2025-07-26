using System;

class Program
{
    static void Main()
    {
        string[] inputN = Console.ReadLine().Split();
        int a = int.Parse(inputN[0]);
        int b = int.Parse(inputN[1]);
        int v = int.Parse(inputN[2]);
        
        
        int day = (v - b - 1) / (a - b) + 1;
        
        Console.WriteLine(day);
    }
}
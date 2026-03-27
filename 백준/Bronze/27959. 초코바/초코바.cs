using System;

class Program
{
    static void Main()
    {
        String[] input = Console.ReadLine().Split(' ');
        int coinCount = int.Parse(input[0]);
        int chocolatePrice = int.Parse(input[1]);
        
        if (coinCount * 100 >= chocolatePrice)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
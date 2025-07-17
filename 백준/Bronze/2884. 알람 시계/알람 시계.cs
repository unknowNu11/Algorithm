using System;

class Program
{
    static void Main()
    {
        int[] time = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int total = (time[0] * 60 + time[1]) - 45;
        if (total < 0) total += 24 * 60;

        Console.WriteLine($"{total / 60} {total % 60}");
    }
}
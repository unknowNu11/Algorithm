using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int loop = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        
        if(loop == 0)
        {
            Console.WriteLine(0);
            return;
        }
        
        for(int i = 0; i < loop; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }
        
        numbers.Sort();
        double n = Math.Round((double)loop / 100 * 15,MidpointRounding.AwayFromZero);
        double sum = 0;
        
        for(int i = (int)n; i < loop - (int)n; i++)
        {
            sum += (double)numbers[i];
        }
        
        Console.WriteLine(Math.Round(sum / ( ((double)loop - n) - n ),MidpointRounding.AwayFromZero ));
    }
}
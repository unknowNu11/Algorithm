using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);
        
        if(a == b && b == c && a == c)
        {
            Console.WriteLine(10000 + (1000 * a));
        }
        else if(a != b && b != c && a != c)
        {    
            int max = Math.Max(a, Math.Max(b, c));   
            Console.WriteLine(100 * max);
        }
        else 
        {
            if (a == b || a == c) Console.WriteLine(1000 + (100 * a));
            else if (b == c) Console.WriteLine(1000 + (100 * b));
        } 
    }
}
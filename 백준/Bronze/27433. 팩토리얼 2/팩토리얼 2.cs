using System;

class Program
{
    static void Main()
    {
        ulong n = 1;
        ulong input = ulong.Parse(Console.ReadLine());
        
        if(input == 0)
        {
            Console.WriteLine(1);
            return;
        }
        
        for(ulong i = 1; i <= input; i++)
        {
            n = n * i;
        }
        
        Console.WriteLine(n);
    }
}
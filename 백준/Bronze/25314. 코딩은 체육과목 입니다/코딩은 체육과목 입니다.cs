using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        for(int i = 1; 4 * i<= n; i++)
        {
            Console.Write("long ");
        }
        
        Console.Write("int");
    }
}
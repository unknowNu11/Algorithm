using System;

class Program
{
    static void Main()
    {
        string num = Console.ReadLine();
        
        for(int a = 1; a <= int.Parse(num); a++)
        {
            for(int b = 1; b <= a; b++)
            {
                Console.Write("*");
                if(a == b)
                    Console.WriteLine();
            }    
        }
    }
}
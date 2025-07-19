using System;

class Program
{
    static void Main()
    {
        int Min = int.MaxValue;
        int Max = int.MinValue;
        
        int roofN = int.Parse(Console.ReadLine());
        string[] inputN = Console.ReadLine().Split();
        
        for(int n = 0; n < roofN; n++)
        {
            if(int.Parse(inputN[n]) < Min)
            {
                Min = int.Parse(inputN[n]);
            }
            
            if(int.Parse(inputN[n]) > Max)
            {
                Max = int.Parse(inputN[n]);
            }  
        }
        
        Console.WriteLine($"{Min} {Max}");
    }
}
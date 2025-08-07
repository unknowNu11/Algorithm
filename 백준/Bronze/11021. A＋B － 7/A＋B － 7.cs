using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        for(int i = 1; i <= n; i++)
        {
            int sum = 0;
            string[] input = Console.ReadLine().Split();
            
            int n1 = int.Parse(input[0]);
            int n2 = int.Parse(input[1]);    
                
            sum = n1 + n2;
            
            Console.WriteLine($"Case #{i}: {sum}");
        }
    }
}
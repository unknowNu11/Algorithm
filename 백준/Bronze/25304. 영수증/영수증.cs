using System;

class Program
{
    static void Main()
    {
        int total = 0;
        int totalPrice = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int price = int.Parse(input[0]) * int.Parse(input[1]);
            total += price;
        }
        
        if(total == totalPrice)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}
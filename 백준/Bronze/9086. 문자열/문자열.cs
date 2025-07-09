using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        for(int a = 0; a < n; a++)
        {
            string input = Console.ReadLine();
            int indexN = input.Length;
            
            Console.Write(input[0]);
            Console.WriteLine(input[indexN - 1]);
        }
    }
}
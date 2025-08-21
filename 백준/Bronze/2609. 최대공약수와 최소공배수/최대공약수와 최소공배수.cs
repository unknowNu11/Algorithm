using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        int originalA = a;
        int originalB = b;
        
        while (b != 0)
        {
            int temp = a % b;
            a = b;
            b = temp;
        }
        
        int c = (originalA * originalB) / a;
        
        Console.WriteLine(a);
        Console.WriteLine(c);
    }
}

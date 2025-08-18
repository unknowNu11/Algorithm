using System;

class Program
{
    static void Main()
    {
        double hashValue = 0;
        int length = int.Parse(Console.ReadLine());
        string str = Console.ReadLine();
        
        int M = 1234567891;
        
        for(int i = 0; i < length; i++)
        {
            hashValue = (hashValue + (str[i] - 'a' + 1) * Math.Pow(31, i)) % M; 
        }
        
        Console.WriteLine(hashValue);
    }
}
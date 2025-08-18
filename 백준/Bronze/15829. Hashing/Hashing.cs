using System;

class Program
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        string str = Console.ReadLine();
        
        int M = 1234567891;
        long hashValue = 0;
        long pow = 1;
        
        for(int i = 0; i < length; i++)
        {
            hashValue = (hashValue + (str[i] - 'a' + 1) * pow) % M; 
            pow = (pow * 31) % M;
        }
        
        Console.WriteLine(hashValue);
    }
}
using System;

class Program
{
    static void Main()
    {
        string a = Console.ReadLine();
        string[] b = Console.ReadLine().Split();
        string c = Console.ReadLine();
        int count = 0;
        
        for(int n = 0; n < int.Parse(a); n++)
        {
            if(int.Parse(b[n]) == int.Parse(c))
                count++;
        }
        
        Console.WriteLine(count);
    }
}
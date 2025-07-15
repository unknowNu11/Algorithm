using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        for (int line = 1; line <= n; line++)
        {
            Console.Write(new string(' ', n - line));
            Console.WriteLine(new string('*', line));
        }
    }
}
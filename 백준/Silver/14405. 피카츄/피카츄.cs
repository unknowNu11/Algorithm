using System;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        input = input.Replace("pi", " ");
        input = input.Replace("ka", " ");
        input = input.Replace("chu", " ");

        if (input.Trim().Length == 0)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}

using System;

class Program
{
    static void Main()
    {
        string n1 = Console.ReadLine();
        string n2 = Console.ReadLine();
        
        Console.WriteLine(int.Parse(n1) * int.Parse(n2[2].ToString()));
        Console.WriteLine(int.Parse(n1) * int.Parse(n2[1].ToString()));
        Console.WriteLine(int.Parse(n1) * int.Parse(n2[0].ToString()));
        Console.WriteLine(int.Parse(n1) * int.Parse(n2));                  
    }
}
using System;

class Program
{
    static void Main()
    {
        string num = Console.ReadLine();
        
        for(int a = 1; a < 10; a++)
        {
            Console.Write(int.Parse(num));
            Console.Write(" * ");
            Console.Write(a);
            Console.Write(" = ");
            Console.WriteLine(int.Parse(num) * a);
        }
    }
}
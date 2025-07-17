using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        
        if(int.Parse(input[1]) >= 45)
        {
            Console.Write(int.Parse(input[0]));
            Console.Write(" ");
            Console.Write(int.Parse(input[1]) - 45);
        }
        else
        {
            if(int.Parse(input[0]) > 0)
            {
                Console.Write(int.Parse(input[0]) - 1);
                Console.Write(" ");
                Console.Write(int.Parse(input[1]) + 60 - 45);
            }
            else
            {
                Console.Write("23");
                Console.Write(" ");
                Console.Write(int.Parse(input[1]) + 60 - 45);
            }
        }
    }
}
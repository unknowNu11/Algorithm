using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        int loofN = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < loofN; i++)
        {
            string input = Console.ReadLine();
            
            if(input == "0")
                stack.Pop();
            else
                stack.Push(int.Parse(input));
        }
        
        int[] elements = stack.ToArray();
        Console.WriteLine(elements.Sum());
    }
}
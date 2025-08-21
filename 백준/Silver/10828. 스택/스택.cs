using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        Stack<int> stack = new Stack<int>();

        for(int i = 0; i < count; i++)
        {
            string[] input = Console.ReadLine().Split();

            switch(input[0])
            {
                case "push":
                    stack.Push(int.Parse(input[1]));
                    break;
                case "pop":
                    if(stack.Count > 0)
                        Console.WriteLine(stack.Pop());
                    else
                        Console.WriteLine("-1");
                    break;
                case "size":
                    Console.WriteLine(stack.Count);
                    break;
                case "empty":
                    Console.WriteLine(stack.Count == 0 ? "1" : "0");
                    break;
                case "top":
                    if(stack.Count > 0)
                        Console.WriteLine(stack.Peek());
                    else
                        Console.WriteLine("-1");
                    break;
                default:
                    break;
            }
        }
    }
}

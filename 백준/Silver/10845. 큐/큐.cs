using System;
using System.Text;
using System.Collections.Generic;

// 삼항연산자 포함
class Program
{
    static void Main()
    {
        StringBuilder str = new StringBuilder();
        
        int loof = int.Parse(Console.ReadLine());
        Queue<int> queue = new Queue<int>();
        int backValue = -1;

        for(int i = 0; i < loof; i++)
        {
            string[] input = Console.ReadLine().Split();
            switch(input[0])
            {
                case "push":
                    int val = int.Parse(input[1]);
                    queue.Enqueue(val);
                    backValue = val;
                    break;
                case "pop":
                    if(queue.Count == 0)
                        str.AppendLine("-1");
                    else
                        str.AppendLine(queue.Dequeue().ToString());
                    break;
                case "size":
                    str.AppendLine(queue.Count.ToString());
                    break;
                case "empty":
                    str.AppendLine(queue.Count == 0 ? "1" : "0");
                    break;
                case "front":
                    str.AppendLine(queue.Count == 0 ? "-1" : queue.Peek().ToString());
                    break;
                case "back":
                    str.AppendLine(queue.Count == 0 ? "-1" : backValue.ToString());
                    break;
            }
        }
        Console.Write(str);
    }
}

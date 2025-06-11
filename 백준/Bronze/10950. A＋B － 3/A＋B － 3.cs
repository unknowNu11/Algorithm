using System;
using System.Text; 

class Program
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine()); 
        StringBuilder answer = new StringBuilder();

        for (int i = 0; i < T; i++)
        {
            string[] input = Console.ReadLine().Split();
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            answer.AppendLine((A + B).ToString()); 
        }

        Console.Write(answer); 
    }
}

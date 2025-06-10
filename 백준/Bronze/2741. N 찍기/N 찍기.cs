using System;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        for (int a = 1; a <= n; a++)
            sb.AppendLine(a.ToString());
        Console.Write(sb.ToString());
    }
}
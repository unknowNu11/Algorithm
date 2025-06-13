using System;
using System.Text;

class Program
{
    static void Main()
    {
        string n = Console.ReadLine();
        StringBuilder sb = new StringBuilder();     
        for(long a = 1; a <= long.Parse(n); a++)
        {
            string[] Plus = Console.ReadLine().Split(); 
            sb.AppendLine((int.Parse(Plus[0]) + int.Parse(Plus[1])).ToString());
        }                     
        Console.Write(sb);
    }
}
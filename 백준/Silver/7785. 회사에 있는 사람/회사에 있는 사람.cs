using System;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int loop = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        Dictionary<string, string> men = new Dictionary<string, string>();

        for (int i = 0; i < loop; i++)
        {
            string[] input = Console.ReadLine().Split();
            string key = input[0];
            string value = input[1];
            men[key] = value;
        }

        List<string> keys = new List<string>(men.Keys);

        keys.Sort();
        keys.Sort((a, b) => b.CompareTo(a));
        
        foreach (string key in keys)
        {
            if (men[key] == "enter")
            {
                sb.AppendLine(key);
            }
        }

        Console.Write(sb);
    }
}

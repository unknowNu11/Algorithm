using System;
using System.Text;

class Program
{
    static void Main()
    {
        int loop = int.Parse(Console.ReadLine());
        int[] numbers = new int[loop];
        for (int i = 0; i < loop; i++)
            numbers[i] = int.Parse(Console.ReadLine());
        
        Array.Sort(numbers);
        
        StringBuilder sb = new StringBuilder();
        foreach (int num in numbers)
            sb.AppendLine(num.ToString());
        Console.Write(sb.ToString());
    }
}
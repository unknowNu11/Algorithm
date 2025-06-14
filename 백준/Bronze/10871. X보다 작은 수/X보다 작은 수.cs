using System;
using System.Text;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        string[] input2 = Console.ReadLine().Split();
        StringBuilder sb = new StringBuilder();
        
        //배열 값
        int n = int.Parse(input[0]);
        //기준 값
        int x = int.Parse(input[1]);
        
        for(int a = 0; a < n; a++)
        {
            if(int.Parse(input2[a]) < x)
                sb.Append(input2[a] + " ");
        }
        
        Console.WriteLine(sb.ToString().Trim());
    }
}
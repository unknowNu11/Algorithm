using System;
using System.Text;

class Program
{
    static void Main()
    {
        int test_case = int.Parse(Console.ReadLine());
        
        for(int a = 0; a < test_case; a++)
        {
            string[] input = Console.ReadLine().Split();
            string s = input[1];
            
            StringBuilder sb = new StringBuilder();
            
            for(int b = 0; b < s.Length; b++)
            {
                for(int c = 0; c < int.Parse(input[0]); c++)
                {
                    sb.Append(s[b]);
                }
            }
            
            Console.WriteLine(sb);
        }
    }
}
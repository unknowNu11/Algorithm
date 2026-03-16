using System;
using System.Text;

class Program
{
    static void Main()
    {
        // 8진법 -> 2진법
        
        /*
        0: 000
        1: 001
        2: 010
        3: 011
        4: 100
        5: 101
        6: 110
        7: 111
        */
        
        String input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        
        for(int i = 0; i < (int)(input.Length); i++)
        {
            switch(input[i] - '0')
            {
                case 0:
                    sb.Append("000");
                    break;
                case 1:
                    sb.Append("001");
                    break;
                case 2:
                    sb.Append("010");
                    break;
                case 3:
                    sb.Append("011");
                    break;
                case 4:
                    sb.Append("100");
                    break;
                case 5:
                    sb.Append("101");
                    break;
                case 6:
                    sb.Append("110");
                    break;
                case 7:
                    sb.Append("111");
                    break;
            }
        }

            while (sb.Length > 1 && sb[0] == '0')
            {
                sb.Remove(0, 1);
            }
        
        
        Console.WriteLine(sb);
    }
}
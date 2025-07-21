using System;

class Program
{
    static void Main()
    {
        int input1 = int.Parse(Console.ReadLine());
        int input2 = int.Parse(Console.ReadLine());
        int input3 = int.Parse(Console.ReadLine());
        
        int multiplyN = input1 * input2 * input3;
        string multiplyS = multiplyN.ToString();
        
        for(int a = 0; a < 10; a++)
        {
            int N = 0;
            
            for(int b = 0; b < multiplyS.Length; b++)
            {
                if((char)(a + '0') == multiplyS[b])
                    N++;
            }
            Console.WriteLine(N);
        }
    }
}
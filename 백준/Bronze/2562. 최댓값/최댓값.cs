using System;

class Program
{
    static void Main()
    {
        string[] inputN = new string[9];
        int maxNum = 0;
        int N = 0;
        
        for(int a = 0; a < 9; a++)
        {
            inputN[a] = Console.ReadLine();
            
            if(maxNum < int.Parse(inputN[a]))
            {
                maxNum = int.Parse(inputN[a]);
                N = a + 1;
            }
        }
        
        Console.WriteLine(maxNum);
        Console.WriteLine(N);
    }
}
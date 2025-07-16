using System;

class Program
{
    static void Main()
    {
        int maxNum = 0;
        int N = 0;
        
        for(int a = 0; a < 9; a++)
        {
            int number = int.Parse(Console.ReadLine());
            
            if(maxNum < number)
            {
                maxNum = number;
                N = a + 1;
            }
        }
        
        Console.WriteLine(maxNum);
        Console.WriteLine(N);
    }
}
using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        int count = 1;
        long temp = 0;
        long a = 0;
        long b = 1;
        
        if (n == 0)
        {
            Console.Write(0);    
        }
        else if (n == 1)
        {
            Console.Write(1);   
        }
        else
        {
            while(count < n)
            {
                count++;
                
                temp = a + b;
                a = b;
                b = temp;
            }
        
            Console.Write(b);   
        }
    }
}
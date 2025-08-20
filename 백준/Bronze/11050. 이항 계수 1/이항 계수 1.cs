using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);
        
        int N_factorial = factorial(N);
        int K_factorial = factorial(K);
        int N_minus_K_factorial = factorial(N - K);
        
        int result = N_factorial / (K_factorial * N_minus_K_factorial);
        Console.WriteLine(result);
    }
    
    static int factorial(int num)
    {
        int factorial_num = 1;
        
        for(int i = 1; i <= num; i++)
        {
            factorial_num = factorial_num * i;
        }
            
        return factorial_num;
    }
}
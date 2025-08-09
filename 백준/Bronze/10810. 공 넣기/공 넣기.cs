using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        
        int n = int.Parse(input[0]); 
        int m = int.Parse(input[1]); 
        
        int[] basket = new int[n]; 
        
        for (int i = 0; i < m; i++)
        {
            string[] input2 = Console.ReadLine().Split();
            
            int start = int.Parse(input2[0]); 
            int end = int.Parse(input2[1]);   
            int ballNum = int.Parse(input2[2]); 
            
            for (int j = start; j <= end; j++)
            {
                basket[j - 1] = ballNum;
            }
        }
        
        for (int k = 0; k < n; k++)
        {
            Console.Write(basket[k] + " ");
        }
    }
}

using System;
using System.Linq;

class Prgram
{
    static void Main()
    {
        int loofN = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        double[] index = new double[loofN];
        
        for(int i = 0; i < loofN; i++)
        {
            index[i] = int.Parse(input[i]);
        }
     
        double maxN = index.Max();
        double sum = 0;
        
        for(int i = 0; i < loofN; i++)
        {
            index[i] = index[i] / (double)maxN * 100;
        }
        
        for(int i = 0; i < loofN; i++)
        {
            sum += index[i];
        }
        
        Console.WriteLine((double)sum / (double)loofN);
    }
}
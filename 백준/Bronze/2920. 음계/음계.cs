using System;

class Program
{
    static void Main()
    {
        bool ascending = true;
        bool descending = true;
        
        string[] inputN = Console.ReadLine().Split();
        
        for (int i = 0; i < 8; i++) 
        {
            int num = int.Parse(inputN[i]);
            if (num != i + 1) ascending = false;
            if (num != 8 - i) descending = false;
        }
     
        
        if(ascending)
        {
            Console.WriteLine("ascending");
        }
        else if(descending)
        {
            Console.WriteLine("descending");
        }
        else
        {
            Console.WriteLine("mixed");
        }
    } 
}
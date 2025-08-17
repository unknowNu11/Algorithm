using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int applyN = 1;
        int countN = 2;
        
        if(input == 1)
        {
            Console.WriteLine("1");
        }
        else
        {
            while (countN <= input) 
            {
		        countN += 6 * applyN;
		        applyN++;
            }
            
            Console.WriteLine($"{applyN}");
        }
    }
}
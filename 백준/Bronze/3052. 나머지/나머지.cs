using System;

class Program
{
    static void Main()
    {
        int[] numberArray = new int[10];
        
        for(int n = 0; n < 10; n++)
        {
            numberArray[n] = int.Parse(Console.ReadLine()) % 42;
        }
        
        Console.WriteLine(numberArray.Distinct().Count());
    }
}
using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        
        int n1 = int.Parse(input[0]);
        int n2 = int.Parse(input[1]);
        
        int c1 = SumNum(n1,n2);
        int c2 = MinusNum(n1,n2);
        int c3 = ApplyNum(c1,c2);
        
        Console.WriteLine(c3.ToString());
    }
    
    static int SumNum(int _n1, int _n2)
    {
        return _n1 + _n2; 
    }
    
    static int MinusNum(int _n1, int _n2)
    {
         return _n1 - _n2; 
    }
    
    static int ApplyNum(int _n1, int _n2)
    {
        return _n1 * _n2;
    }
}
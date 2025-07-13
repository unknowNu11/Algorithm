using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        
        long n1 = long.Parse(input[0]);
        long n2 = long.Parse(input[1]);
        
        long c1 = SumNum(n1,n2);
        long c2 = MinusNum(n1,n2);
        long c3 = ApplyNum(c1,c2);
        
        Console.WriteLine(c3.ToString());
    }
    
    static long SumNum(long _n1, long _n2)
    {
        return _n1 + _n2; 
    }
    
    static long MinusNum(long _n1, long _n2)
    {
         return _n1 - _n2; 
    }
    
    static long ApplyNum(long _n1, long _n2)
    {
        return _n1 * _n2;
    }
}
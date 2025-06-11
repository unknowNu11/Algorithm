using System;

class Program
{
    static void Main()
    {
        while(true)
        {
            string[] num = Console.ReadLine().Split();
            
            if(int.Parse(num[0]) == 0 && int.Parse(num[1]) == 0)
                break;
            else
                Console.WriteLine( int.Parse(num[0]) + int.Parse(num[1]) );
        }
    }
}
using System;

class Program
{
    static void Main()
    {
       while(true)
       {
            string[] input = Console.ReadLine().Split();
        
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            
            if(a == 0 && b == 0 && c == 0)
                return;
           
            if(a * a == b * b + c * c)
                Console.WriteLine("right");
            else if(b * b == a * a + c * c)
                Console.WriteLine("right");
            else if(c * c == a * a + b * b)
                Console.WriteLine("right");
            else
                Console.WriteLine("wrong");
       }
    }
}
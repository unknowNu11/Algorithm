using System;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());  // 테스트 개수
        
        for (int a = 0; a < t; a++)
        {
            string[] input = Console.ReadLine().Split();
            
            int H = int.Parse(input[0]);
            int W = int.Parse(input[1]);
            int N = int.Parse(input[2]);
            
            int floor = N % H;
            int room = N / H + 1;
            
            if (floor == 0)
            {
                floor = H;
                room = N / H;
            }
            
            Console.WriteLine($"{floor}{room:00}");
        }
    }
}

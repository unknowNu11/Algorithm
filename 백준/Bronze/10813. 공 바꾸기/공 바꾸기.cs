using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        
        int N = int.Parse(input[0]); // 바구니 수
        int M = int.Parse(input[1]); // 교환 횟수
        
        int[] basket = new int[N];

        // 바구니 초기화 (1번 바구니에 1번 공)
        for (int i = 0; i < N; i++)
        {
            basket[i] = i + 1;
        }
        
        // 공 교환
        for (int j = 0; j < M; j++)
        {
            string[] input2 = Console.ReadLine().Split();
            
            int n1 = int.Parse(input2[0]) - 1; // 인덱스 보정
            int n2 = int.Parse(input2[1]) - 1;
            
            int temp = basket[n1];
            basket[n1] = basket[n2];
            basket[n2] = temp;
        }
        
        // 결과 출력
        for (int k = 0; k < N; k++)
        {
            Console.Write($"{basket[k]} ");
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        string[] indexNum = Console.ReadLine().Split();
        int n = int.Parse(indexNum[0]);
        int m = int.Parse(indexNum[1]);

        int[,] index1 = new int[n, m];
        int[,] index2 = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            string[] row = Console.ReadLine().Split();
            for (int j = 0; j < m; j++)
            {
                index1[i, j] = int.Parse(row[j]);
            }
        }

        for (int i = 0; i < n; i++)
        {
            string[] row = Console.ReadLine().Split();
            for (int j = 0; j < m; j++)
            {
                index2[i, j] = int.Parse(row[j]);
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(index1[i, j] + index2[i, j]);
                //마지막이 아니라면 한칸은 띄워주겠어,,,
                if (j != m - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
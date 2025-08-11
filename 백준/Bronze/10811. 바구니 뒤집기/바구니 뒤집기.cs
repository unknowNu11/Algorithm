using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        int[] index = new int[n];
        for (int i = 0; i < n; i++)
            index[i] = i + 1;

        for (int t = 0; t < m; t++)
        {
            string[] range = Console.ReadLine().Split();
            int first = int.Parse(range[0]) - 1;
            int end = int.Parse(range[1]) - 1;   

            for (int left = first, right = end; left < right; left++, right--)
            {
                int temp = index[left];
                index[left] = index[right];
                index[right] = temp;
            }
        }

        Console.WriteLine(string.Join(" ", index));
    }
}

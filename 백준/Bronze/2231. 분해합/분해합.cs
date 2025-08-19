using System;
class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        if (input == 1)
        {
            Console.WriteLine(0);
            return;
        }

        for (int i = 0; i < input; i++)
        {
            int sum = 0;

            string str = i.ToString();
            for (int j = 0; j < str.Length; j++)
            {
                sum += str[j] - '0';
            }

            if (i + sum == input)
            {
                Console.WriteLine(i); 
                return; 
            }
        }

        Console.WriteLine(0);
    }
}

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int input1 = int.Parse(Console.ReadLine());
        int input2 = int.Parse(Console.ReadLine());
        int input3 = int.Parse(Console.ReadLine());

        string applyN = (input1 * input2 * input3).ToString();

        for (int a = 0; a < 10; a++)
        {
            int count = applyN.Count(c => c == (char)(a + '0'));
            Console.WriteLine(count);
        }
    }
}
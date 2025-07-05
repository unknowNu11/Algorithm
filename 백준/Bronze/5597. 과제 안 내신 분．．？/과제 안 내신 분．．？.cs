using System;

class Program
{
    static void Main()
    {
        bool[] student_index = new bool[31]; 

        for (int i = 0; i < 28; i++)
        {
            int num = int.Parse(Console.ReadLine());
            student_index[num] = true;
        }

        for (int i = 1; i <= 30; i++)
        {
            if (!student_index[i])
                Console.WriteLine(i);
        }
    }
}
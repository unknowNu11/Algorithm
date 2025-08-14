using System;

class Program
{
    static void Main()
    {
        while(true)
        {
            string input = Console.ReadLine();
            bool trueN = true;
            
            if(input[0] == '0')
                break;
            
            for(int first = 0, end = input.Length - 1; first < end; first++, end--)
            {
                if(input[first] != input[end])
                    trueN = false;
            }
            
            if(trueN)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
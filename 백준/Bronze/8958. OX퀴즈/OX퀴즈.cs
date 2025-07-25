using System;

class Program
{
    static void Main()
    {
        string loof = Console.ReadLine();
        for(int n = 0; n < int.Parse(loof); n++)
        {
            string input = Console.ReadLine();
            int point = 0;
            int plusP = 0;
            
            for(int ox = 0; ox < input.Length; ox++)
            {
                if(input[ox].ToString() == "O")
                    plusP += 1;
                else
                    plusP = 0;
                
                point += plusP;
            }
            
            Console.WriteLine(point);
        }
    }
}
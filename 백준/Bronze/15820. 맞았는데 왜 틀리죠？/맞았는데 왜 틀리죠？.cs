using System;

class Program
{
    static void Main()
    {     
        String[] countNumber = Console.ReadLine().Split(' ');
        long sampleTestCount = long.Parse(countNumber[0]);
        long systemTestCount = long.Parse(countNumber[1]);
        int caseType = 1;
            
        for (int i = 0; i < sampleTestCount; ++i)
        {
            String[] input = Console.ReadLine().Split(' ');
            
            if (long.Parse(input[0]) < long.Parse(input[1]))
            {
                caseType = 2;
                break;
            }
            else  if (long.Parse(input[0]) > long.Parse(input[1]))
            {
                caseType = 2;
                break;
            }
        }
        
        for (int i = 0; i < systemTestCount; ++i)
        {
            if (caseType == 2)
                break;
            
            String[] input = Console.ReadLine().Split(' ');
            
            if (long.Parse(input[0]) < long.Parse(input[1]))
            {
                caseType = 3;
                break;
            }
            else  if (long.Parse(input[0]) > long.Parse(input[1]))
            {
                caseType = 3;
                break;
            }
        }
        
        switch(caseType)
        {
            case 1:
                Console.Write("Accepted");
                break;
            case 2:
                Console.Write("Wrong Answer");
                break;
            case 3:
                Console.Write("Why Wrong!!!");
                break;
            default:
                break;
        }
    }
}
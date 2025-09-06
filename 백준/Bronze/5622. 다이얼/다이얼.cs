string input = Console.ReadLine();
int timeSum = 0;

for(int i = 0; i < input.Length; i++)
{
    if(input[i] == 'A' || input[i] == 'B' || input[i] == 'C')
    {
        timeSum += 3;
    }
    else if(input[i] == 'D' || input[i] == 'E' || input[i] == 'F')
    {
         timeSum += 4;
    }
    else if(input[i] == 'G' || input[i] == 'H' || input[i] == 'I')
    {
         timeSum += 5;
    }
    else if(input[i] == 'J' || input[i] == 'K' || input[i] == 'L')
    {
         timeSum += 6;
    }
    else if(input[i] == 'M' || input[i] == 'N' || input[i] == 'O')
    {
         timeSum += 7;
    }    
    else if(input[i] == 'P' || input[i] == 'Q' || input[i] == 'R' || input[i] == 'S')
    {
         timeSum += 8;
    }
    else if(input[i] == 'T' || input[i] == 'U' || input[i] == 'V')
    {
         timeSum += 9;
    }
    else if(input[i] == 'W' || input[i] == 'X' || input[i] == 'Y' || input[i] == 'Z')
    {
         timeSum += 10;
    }
}

Console.WriteLine(timeSum);
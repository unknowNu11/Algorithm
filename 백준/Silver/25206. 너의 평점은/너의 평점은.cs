double sum = 0;
double rating = 0;
double ratingSum = 0;

for(int i = 0; i < 20; i++)
{
    string[] input = Console.ReadLine().Split();
    
    switch(input[2].ToString())
    {
        case "A+":
            ratingSum += double.Parse(input[1]);
            sum += double.Parse(input[1]) * 4.5;
            break;
        case "A0":
            ratingSum += double.Parse(input[1]);
             sum += double.Parse(input[1]) * 4.0;
            break;
        case "B+":
            ratingSum += double.Parse(input[1]);
             sum += double.Parse(input[1]) * 3.5;
            break;
        case "B0":
            ratingSum += double.Parse(input[1]);
             sum += double.Parse(input[1]) * 3.0;
            break;
        case "C+":
            ratingSum += double.Parse(input[1]);
             sum += double.Parse(input[1]) * 2.5;
            break;
        case "C0":
            ratingSum += double.Parse(input[1]);
             sum += double.Parse(input[1]) * 2.0;
            break;
        case "D+":
            ratingSum += double.Parse(input[1]);
            sum += double.Parse(input[1]) * 1.5;
            break;
        case "D0":
            ratingSum += double.Parse(input[1]);
            sum += double.Parse(input[1]) * 1.0;
            break;
        case "F":
            ratingSum += double.Parse(input[1]);
            sum += double.Parse(input[1]) * 0.0;
            break;
        default: // P
            break;
    }
}

Console.WriteLine(sum / ratingSum);
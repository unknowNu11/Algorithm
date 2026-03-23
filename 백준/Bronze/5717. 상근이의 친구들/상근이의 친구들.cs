while(true)
{
    String[] input = Console.ReadLine().Split(' ');
    
    if(input[0] == input[1] && int.Parse(input[0]) == 0)
        return;
    
    Console.WriteLine(int.Parse(input[0]) + int.Parse(input[1]));
}
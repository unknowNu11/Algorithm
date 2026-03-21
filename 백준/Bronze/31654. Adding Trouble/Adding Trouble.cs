string[] input = Console.ReadLine().Split(' ');

if(int.Parse(input[0]) + int.Parse(input[1]) == int.Parse(input[2]))
{
    Console.WriteLine("correct!");
}
else
{
    Console.WriteLine("wrong!");
}
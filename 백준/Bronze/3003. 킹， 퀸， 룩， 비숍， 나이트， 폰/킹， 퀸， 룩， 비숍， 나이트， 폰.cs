// LINQ를 사용해봅시다...
int[] peiceCount = {1, 1, 2, 2, 2, 8};
int[] inputs = Console.ReadLine()
                     .Split(' ')
                     .Select(int.Parse)
                     .ToArray();

int needPeiceCount = 0;

for (int i = 0; i < 6; i++)
{
    needPeiceCount = peiceCount[i] - inputs[i];
    
    Console.Write(needPeiceCount);
    Console.Write(' ');
}
long total = 0;
long count = 0;
long input = long.Parse(Console.ReadLine());

while (total + count < input)
{
    count++;
    total += count;
}

Console.WriteLine(count);
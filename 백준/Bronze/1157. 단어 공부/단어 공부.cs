string input = Console.ReadLine().ToUpper();
int[] counts = new int[26];

foreach (char c in input)
{
    counts[c - 'A']++;
}

int max = -1;
int maxIdx = -1;
bool multiple = false;
for (int i = 0; i < 26; i++)
{
    if (counts[i] > max)
    {
        max = counts[i];
        maxIdx = i;
        multiple = false;
    }
    else if (counts[i] == max)
    {
        multiple = true;
    }
}

Console.WriteLine(multiple ? "?" : ((char)(maxIdx + 'A')).ToString());
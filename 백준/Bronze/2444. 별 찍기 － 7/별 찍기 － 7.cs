using System;
using System.Text;

int input = int.Parse(Console.ReadLine());
int space;
int star;

StringBuilder sb = new StringBuilder();

for (int i = 0; i < input * 2 - 1; i++)
{
    space = Math.Abs(input - 1 - i);
    star  = 2 * (input - 1 - space) + 1;

    sb.Append(' ', space);
    sb.Append('*', star);

    Console.WriteLine(sb);
    sb.Clear();
}

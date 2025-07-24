using System;

class Program
{
    static void Main()
    {
         string s = Console.ReadLine();

         for (int i = 97; i < 123; i++)
         {
             Console.Write(s.IndexOf(Convert.ToChar(i)));
             Console.Write(" ");
         }
    }
}
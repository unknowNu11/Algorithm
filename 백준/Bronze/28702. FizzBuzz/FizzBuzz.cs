using System;

class Program
{
public static void Main()
{    
    int number = 0;
    
    for (int i = 0; i < 3; ++i)
    {
        string input = Console.ReadLine();   
        
        // 3의 배수
        // 5의 배수
        // 15의 배수
        // 연속적으로 n n n 불가능
        // 즉 숫자는 반드시 한개 존재를 이용하였다.
        
        if (int.TryParse(input, out int num))
        {
            number = num + (3 - i);
            break;
        }
    }
    
    GuessNumber(number);
}

static void GuessNumber(int num)
{
    if (num % 15 == 0)
    {
        Console.WriteLine("FizzBuzz");
        return;
    }
    else if (num % 3 == 0)
    {
        Console.WriteLine("Fizz");
        return;
    }
    else if (num % 5 == 0)
    {
        Console.WriteLine("Buzz");
        return;
    }
    
    Console.WriteLine(num);
}
}
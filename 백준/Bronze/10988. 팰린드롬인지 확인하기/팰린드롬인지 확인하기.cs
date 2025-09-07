string input = Console.ReadLine();

if(input.Length == 1)
{
    Console.WriteLine(1);
}
else
{
    bool isPalindrome = true;
    for(int i = 0; i < input.Length / 2; i++)
    {
        if(input[i] != input[input.Length - i - 1])
        {
            isPalindrome = false;
            break;
        }
    }
    Console.WriteLine(isPalindrome ? 1 : 0);
}
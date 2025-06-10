class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int result = 1;
        
        //1은 불필요한 연산이니 제외 
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        Console.WriteLine(result);
    }
}
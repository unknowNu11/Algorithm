
        string[] input = Console.ReadLine().Split();

        string[] input2 = Console.ReadLine().Split();

        int count = int.Parse(input[0]);

        int input_val = int.Parse(input[1]);

        int sum = 0;
        int min = 0;
        int[] num = new int[count];

        for (int i = 0; i < count; i++)
        {
            num[i] = int.Parse(input2[i]);
        }

        for (int i = 0; i < count; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                for (int k = j + 1; k < count; k++)
                {
                    sum = num[i] + num[j] + num[k];

                    if(sum <=input_val && min < sum)
                    {
                        min = sum;
                    }
                }
            }
        }
        Console.Write(min);
    


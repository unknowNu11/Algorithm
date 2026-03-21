string[] input1 = Console.ReadLine().Split(' ');
string[] input2 = Console.ReadLine().Split(' ');

int h = int.Parse(input1[0]);
int w = int.Parse(input1[1]);

int[,] map = new int[w,h];

int firstIndex = 0;    // 처음
int lastIndex = 0;     // 마지막
int count = 0;         // 개수
int total = 0;         // 빗물 고인수 = 마지막 - 개수 - 처음

// 벽 채우기
for (int i = 0; i < w; i++)
{
    for (int j = 0; j < h; j++)
    {
        if (j < int.Parse(input2[i]))
        {
            map[i,j] = 1;   
        }
    }   
}

// 처음, 마지막, 개수 구하기
for (int i = 0; i < h; i++)
{
    firstIndex = -1;
    lastIndex = -1;
    count = 0;

    for (int j = 0; j < w; j++)
    {
        if (map[j,i] == 1)
        {
            if (firstIndex == -1)
                firstIndex = j;

            lastIndex = j;
        }
    }   
    
    for(int j = firstIndex + 1; j < lastIndex; j++) 
    {
        if(map[j,i] == 0) count++;
    }

    total += count;
}

Console.Write(total);
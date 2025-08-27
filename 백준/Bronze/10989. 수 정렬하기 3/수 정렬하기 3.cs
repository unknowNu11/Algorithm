using System.Text;

// 남의 풀이 입니다 왜 되는지 확인중 . . .
var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
var sw = new StreamWriter(Console.OpenStandardOutput())
{
    AutoFlush = false
};

var counts = new int[10000];

for (int i = 0; i < counts.Length; ++i) {
    counts[i] = 0;
}

var line = sr.ReadLine();
if (line == null)
    return;
int n = int.Parse(line);

for (int i = 0; i < n; ++i) {
    line = sr.ReadLine();
    if (line == null)
        return;
    int x = int.Parse(line);
    counts[x - 1]++;
}

for (int i = 0; i < counts.Length; ++i) {
    for (int j = 0; j < counts[i]; ++j) {
        sw.WriteLine(i + 1);
    }
}

sw.Flush();
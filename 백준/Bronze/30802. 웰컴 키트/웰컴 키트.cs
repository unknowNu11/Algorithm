int _sum = int.Parse(Console.ReadLine());
int[] _order = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] _bundle = Console.ReadLine().Split().Select(int.Parse).ToArray();

Console.WriteLine($"{_order.Select(x => (x + _bundle[0] - 1) / _bundle[0]).Sum()}\n{_sum / _bundle[1]} {_sum % _bundle[1]}");
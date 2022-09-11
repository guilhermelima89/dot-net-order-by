using BenchmarkDotNet.Attributes;

namespace Ordering;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    private readonly Random _random = new(420);

    private int[] _items;

    [GlobalSetup]
    public void Setup()
    {
        _items = Enumerable.Range(1, 100).Select(_ => _random.Next()).ToArray();
    }

    [Benchmark]
    public int[] OrderBy() => _items.OrderBy(x => x).ToArray();

    [Benchmark]
    public int[] Order() => _items.Order().ToArray();

    [Benchmark]
    public int[] OrderByDesc() => _items.OrderByDescending(x => x).ToArray();

    [Benchmark]
    public int[] OrderDesc() => _items.OrderDescending().ToArray();
}
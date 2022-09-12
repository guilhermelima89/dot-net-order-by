using BenchmarkDotNet.Attributes;

namespace Ordering;

[MemoryDiagnoser(false)]
public class BenchmarksList
{
    private readonly Random _random = new(420);

    [Benchmark]
    public List<int> OrderBy()
    {
        var items = Enumerable.Range(1, 100).Select(_ => _random.Next());
        return items.OrderBy(x => x).ToList();
    }

    [Benchmark]
    public List<int> Order()
    {
        var items = Enumerable.Range(1, 100).Select(_ => _random.Next());
        return items.Order().ToList();
    }

    [Benchmark]
    public List<int> Sort()
    {
        var items = Enumerable.Range(1, 100).Select(_ => _random.Next()).ToList();
        items.Sort();
        return items;
    }
}
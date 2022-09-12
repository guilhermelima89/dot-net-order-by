using BenchmarkDotNet.Attributes;

namespace Ordering;

[MemoryDiagnoser(false)]
public class BenchmarksWithText
{
    private readonly Random _random = new(420);

    [Benchmark]
    public List<string> OrderBy()
    {
        var items = Enumerable.Range(1, 100).Select(_ => _random.Next().ToString());
        return items.OrderBy(x => x).ToList();
    }

    [Benchmark]
    public List<string> Order()
    {
        var items = Enumerable.Range(1, 100).Select(_ => _random.Next().ToString());
        return items.Order().ToList();
    }

    [Benchmark]
    public List<string> Sort()
    {
        var items = Enumerable.Range(1, 100).Select(_ => _random.Next().ToString()).ToList();
        items.Sort();
        return items;
    }
}
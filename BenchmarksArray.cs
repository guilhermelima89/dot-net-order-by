using BenchmarkDotNet.Attributes;

namespace Ordering;

[MemoryDiagnoser(false)]
public class BenchmarksArray
{
    private readonly Random _random = new(420);

    [Benchmark]
    public int[] OrderBy()
    {
        var items = Enumerable.Range(1, 100).Select(_ => _random.Next()).ToArray();
        return items.OrderBy(x => x).ToArray();
    }

    [Benchmark]
    public int[] Order()
    {
        var items = Enumerable.Range(1, 100).Select(_ => _random.Next()).ToArray();
        return items.Order().ToArray();
    }

    [Benchmark]
    public int[] Sort()
    {
        var items = Enumerable.Range(1, 100).Select(_ => _random.Next()).ToArray();
        Array.Sort(items);
        return items;
    }

    [Benchmark]
    public int[] SpanSort()
    {
        Span<int> items = Enumerable.Range(1, 100).Select(_ => _random.Next()).ToArray();
        items.Sort();
        return items.ToArray();
    }
}
## DOT NET 7

# commands

- dotnet new console -n Ordering
- dotnet add package BenchmarkDotNet --version 0.13.2
- dotnet run --configuration Release or dotnet -c Release

# run

```csharp

BenchmarkRunner.Run<BenchmarksList>();

```

# class Benchmarks

```ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.856/21H2)
AMD Ryzen 7 3800X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.100-preview.7.22377.5
  [Host]     : .NET 7.0.0 (7.0.22.37506), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.37506), X64 RyuJIT AVX2


```

| Method      |     Mean |     Error |    StdDev | Allocated |
| ----------- | -------: | --------: | --------: | --------: |
| OrderBy     | 4.287 μs | 0.0261 μs | 0.0231 μs |   1.83 KB |
| Order       | 4.177 μs | 0.0238 μs | 0.0211 μs |   1.41 KB |
| OrderByDesc | 4.596 μs | 0.0886 μs | 0.0910 μs |   1.83 KB |
| OrderDesc   | 4.416 μs | 0.0425 μs | 0.0397 μs |   1.41 KB |

# class BenchmarksArray

```ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.856/21H2)
AMD Ryzen 7 3800X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.100-preview.7.22377.5
  [Host]     : .NET 7.0.0 (7.0.22.37506), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.37506), X64 RyuJIT AVX2


```

| Method   |     Mean |     Error |    StdDev | Allocated |
| -------- | -------: | --------: | --------: | --------: |
| OrderBy  | 6.734 μs | 0.0466 μs | 0.0413 μs |    2448 B |
| Order    | 6.527 μs | 0.0835 μs | 0.0781 μs |    2024 B |
| Sort     | 2.818 μs | 0.0198 μs | 0.0185 μs |     576 B |
| SpanSort | 2.888 μs | 0.0307 μs | 0.0287 μs |    1000 B |

# class BenchmarksList

```ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.856/21H2)
AMD Ryzen 7 3800X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.100-preview.7.22377.5
  [Host]     : .NET 7.0.0 (7.0.22.37506), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.37506), X64 RyuJIT AVX2


```

| Method  |     Mean |     Error |    StdDev | Allocated |
| ------- | -------: | --------: | --------: | --------: |
| OrderBy | 7.020 μs | 0.0729 μs | 0.0682 μs |    2056 B |
| Order   | 6.696 μs | 0.0694 μs | 0.0649 μs |    1632 B |
| Sort    | 2.928 μs | 0.0061 μs | 0.0054 μs |     608 B |

# class BenchmarksWithText

```ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.856/21H2)
AMD Ryzen 7 3800X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.100-preview.7.22377.5
  [Host]     : .NET 7.0.0 (7.0.22.37506), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.37506), X64 RyuJIT AVX2


```

| Method  |     Mean |    Error |   StdDev | Allocated |
| ------- | -------: | -------: | -------: | --------: |
| OrderBy | 37.24 μs | 0.291 μs | 0.243 μs |   7.53 KB |
| Order   | 35.60 μs | 0.093 μs | 0.083 μs |   6.73 KB |
| Sort    | 39.64 μs | 0.254 μs | 0.212 μs |   5.31 KB |

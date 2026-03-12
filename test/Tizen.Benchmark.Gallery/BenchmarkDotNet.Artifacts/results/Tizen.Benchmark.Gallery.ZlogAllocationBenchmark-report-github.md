```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.3775/24H2/2024Update/HudsonValley)
11th Gen Intel Core i7-11600H 2.90GHz (Max: 2.92GHz), 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.103
  [Host]     : .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v4


```
| Method                                 | Mean     | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|--------------------------------------- |---------:|----------:|----------:|------:|--------:|----------:|------------:|
| &#39;Legacy: String Concatenation&#39;         | 1.236 ms | 0.0230 ms | 0.0216 ms |  1.00 |    0.02 |   1.26 KB |        1.00 |
| &#39;Legacy: String.Format&#39;                | 1.213 ms | 0.0124 ms | 0.0110 ms |  0.98 |    0.02 |   1.18 KB |        0.94 |
| &#39;Zlog: Interpolated (Zero-Allocation)&#39; | 1.201 ms | 0.0070 ms | 0.0062 ms |  0.97 |    0.02 |   1.05 KB |        0.83 |

using BenchmarkDotNet.Running;

namespace Tizen.WindowSystem.Benchmark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<InteropBenchmarks>();
        }
    }
}

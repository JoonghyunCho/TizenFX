using BenchmarkDotNet.Attributes;
using Tizen.WindowSystem;
using System;
using Tizen.WindowSystem.Shell;

namespace Tizen.WindowSystem.Benchmark
{
    [MemoryDiagnoser]
    public class InteropBenchmarks
    {
        // Note: These benchmarks serve to measure the overhead of P/Invoke.
        // On a non-Tizen system, the native libraries will be missing, causing DllNotFoundException.
        // In a real Tizen environment, this would compare DllImport vs LibraryImport performance.

        [Benchmark]
        public void CreateTizenShell()
        {
            try
            {
                using (var shell = new TizenShell())
                {
                }
            }
            catch (DllNotFoundException)
            {
                // Expected on non-Tizen OS
            }
            catch (Exception)
            {
                // Ignore other exceptions for benchmark stability if native lib is missing
            }
        }

        [Benchmark]
        public void CreateInputGesture()
        {
            try
            {
                using (var gesture = new InputGesture())
                {
                }
            }
            catch (DllNotFoundException)
            {
                // Expected on non-Tizen OS
            }
            catch (Exception)
            {
            }
        }
    }
}

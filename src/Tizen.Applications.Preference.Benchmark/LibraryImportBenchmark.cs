using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Runtime.InteropServices;
using Tizen.Applications;

namespace Tizen.Applications.Preference.Benchmark
{
    [MemoryDiagnoser]
    public partial class LibraryImportBenchmark
    {
        internal const string LibPreference = "libcapi-appfw-preference.so.0";
        private const string TestKey = "test_key";
        private const string TestValue = "test_value";
        // 256 chars string to verify allocation difference
        private static readonly string TestValueLong = new string('a', 256);

        [GlobalSetup]
        public void Setup()
        {
            // Environment setup if needed
        }

        [Benchmark]
        public void Legacy_SetString_Short()
        {
            LegacyInterop.SetString(TestKey, TestValue);
        }

        [Benchmark]
        public void New_SetString_Short()
        {
            NewInterop.SetString(TestKey, TestValue);
        }

        [Benchmark]
        public void Legacy_SetString_Long()
        {
            LegacyInterop.SetString(TestKey, TestValueLong);
        }

        [Benchmark]
        public void New_SetString_Long()
        {
            NewInterop.SetString(TestKey, TestValueLong);
        }
        
        [Benchmark]
        public void Legacy_GetString()
        {
             string val;
             LegacyInterop.GetString(TestKey, out val);
        }

        [Benchmark]
        public void New_GetString()
        {
             string val;
             NewInterop.GetString(TestKey, out val);
        }

        // ----------------------------------------------------------------------------
        // Legacy DllImport Implementation
        // ----------------------------------------------------------------------------
        internal static class LegacyInterop
        {
            [DllImport(LibPreference, EntryPoint = "preference_set_string")]
            internal static extern int SetString(string key, string value);

            [DllImport(LibPreference, EntryPoint = "preference_get_string")]
            internal static extern int GetString(string key, out string value);
        }

        // ----------------------------------------------------------------------------
        // New LibraryImport Implementation
        // ----------------------------------------------------------------------------
        internal static partial class NewInterop
        {
            [LibraryImport(LibPreference, EntryPoint = "preference_set_string", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial int SetString(string key, string value);

            [LibraryImport(LibPreference, EntryPoint = "preference_get_string", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial int GetString(string key, out string value);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "--stress-test")
            {
                RunStressTest();
            }
            else
            {
                var summary = BenchmarkRunner.Run<LibraryImportBenchmark>();
            }
        }

        private static void RunStressTest()
        {
            const int Iterations = 1_000_000;
            // Warmup
            LibraryImportBenchmark.LegacyInterop.SetString("warmup", "warmup");
            LibraryImportBenchmark.NewInterop.SetString("warmup", "warmup");

            long beforeLegacy = GC.GetTotalAllocatedBytes();
            for (int i = 0; i < Iterations; i++)
            {
                LibraryImportBenchmark.LegacyInterop.SetString("key", "value_long_string_for_test");
            }
            long afterLegacy = GC.GetTotalAllocatedBytes();

            long beforeNew = GC.GetTotalAllocatedBytes();
            for (int i = 0; i < Iterations; i++)
            {
                LibraryImportBenchmark.NewInterop.SetString("key", "value_long_string_for_test");
            }
            long afterNew = GC.GetTotalAllocatedBytes();

            Console.WriteLine($"Legacy Allocation (1M ops): {afterLegacy - beforeLegacy:N0} Bytes");
            Console.WriteLine($"New Allocation    (1M ops): {afterNew - beforeNew:N0} Bytes");
        }
    }
}

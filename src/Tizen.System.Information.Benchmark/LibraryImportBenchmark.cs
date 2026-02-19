using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Runtime.InteropServices;
using Tizen.System;

namespace Tizen.System.Information.Benchmark
{
    [MemoryDiagnoser]
    public partial class LibraryImportBenchmark
    {
        // Re-definition of internal enum for benchmark purposes if needed, 
        // or we use the one from project if InternalsVisibleTo is set.
        // Since we didn't set InternalsVisibleTo, we cast int to the enum type key or just use the enum if public.
        // Checked: RuntimeInfoKey is internal. 
        // Strategy: Define a local enum matching it or just use int and cast if possible? 
        // RuntimeInfoKey is checked in the interop? No, it's just passed through.
        // We will define a compatible enum here to avoid access issues, or use reflection/UnsafeAccessor if strictly needed.
        // But for Interop calls, the enum underlying type is int.
        public enum BenchmarkRuntimeInfoKey
        {
            Bluetooth = 2,
            WifiHotspot = 3
        }

        // Mocking the Libraries const for benchmark
        internal const string LibRuntimeInfo = "libcapi-system-runtime-info.so.0";

        [GlobalSetup]
        public void Setup()
        {
            // Environment setup if needed
        }

        [Benchmark]
        public void Legacy_GetValue_Bool()
        {
            LegacyInterop.GetValue(BenchmarkRuntimeInfoKey.Bluetooth, out bool val);
        }

        [Benchmark]
        public void New_GetValue_Bool()
        {
            NewInterop.GetValue(BenchmarkRuntimeInfoKey.Bluetooth, out bool val);
        }

        [Benchmark]
        public void Legacy_GetValue_String()
        {
            LegacyInterop.GetValue(BenchmarkRuntimeInfoKey.WifiHotspot, out string val);
        }

        [Benchmark]
        public void New_GetValue_String()
        {
            NewInterop.GetValue(BenchmarkRuntimeInfoKey.WifiHotspot, out string val);
        }

        // ----------------------------------------------------------------------------
        // Legacy DllImport Implementation (Simulated for comparison)
        // ----------------------------------------------------------------------------
        internal static class LegacyInterop
        {
            [DllImport(LibRuntimeInfo, EntryPoint = "runtime_info_get_value_bool")]
            public static extern int GetValue(BenchmarkRuntimeInfoKey key, out bool status);

            [DllImport(LibRuntimeInfo, EntryPoint = "runtime_info_get_value_string")]
            public static extern int GetValue(BenchmarkRuntimeInfoKey key, out string status);
        }

        // ----------------------------------------------------------------------------
        // New LibraryImport Implementation (Copy of what we generated or referencing it)
        // Since the actual implementation is internal, we replicate the Source Generator pattern here
        // to benchmark the *mechanism* without needing to expose internals.
        // ----------------------------------------------------------------------------
        internal static partial class NewInterop
        {
            [LibraryImport(LibRuntimeInfo, EntryPoint = "runtime_info_get_value_bool")]
            public static partial int GetValue(BenchmarkRuntimeInfoKey key, [MarshalAs(UnmanagedType.I1)] out bool status);

            [LibraryImport(LibRuntimeInfo, EntryPoint = "runtime_info_get_value_string", StringMarshalling = StringMarshalling.Utf8)]
            public static partial int GetValue(BenchmarkRuntimeInfoKey key, out string status);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<LibraryImportBenchmark>();
        }
    }
}
